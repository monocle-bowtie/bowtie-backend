using SistAdmin.Models;
using log4net;
using System;
using Mastercard.Exceptions;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;

namespace SistAdmin.Services
{
	public abstract class BaseService
	{
		private static readonly ILog log = LogManager.GetLogger(typeof(BaseService));

		protected bowtieEntities db;

        public BaseService setDatabase(bowtieEntities db)
		{
			this.db = db;
			return this;
		}

		public Usuario getCurrentUsuario()
		{
			return this.db.Usuario.Where(
				u => u.Usuario1 == Thread.CurrentPrincipal.Identity.Name
			).FirstOrDefault();
		}

		public int save()
		{
			try
			{
				return this.db.SaveChanges();
			}
			catch (DbUpdateException e)
			{
				log.Error(e.Message, e);
				string sqlMessage = null;
				var sqlException = e.GetBaseException() as SqlException;
				if (sqlException != null)
				{
					if (sqlException.Errors.Count > 0)
					{
						switch (sqlException.Errors[0].Number)
						{
							case 547: // Foreign Key violation
								sqlMessage = "No se puede actualizar el registro por referencias dependientes.";
								break;
							case 2627:
								sqlMessage = "Ya existe una entidad idéntica";
								break;
						}
					}
				}
				if (sqlMessage != null)
				{
					throw new ServiceException(sqlMessage);
				}
				else
				{
					throw new ServiceException("Error inesperado: " + e.Message);
				}
			}
			catch (DbEntityValidationException e)
			{
				List<string> details = new List<string>();
				foreach (DbEntityValidationResult res in e.EntityValidationErrors)
				{
					foreach (DbValidationError err in res.ValidationErrors)
					{
						string detail = res.Entry.Entity.GetType().Name + "." + err.PropertyName + ": " + err.ErrorMessage;
						details.Add(detail);
						Trace.WriteLine("----------------->" + detail);
					}
				}
				throw new ServiceException("Error inesperado: " + e.Message, details);
			}
			catch (Exception e)
			{
				Trace.WriteLine("----------------->");
				Trace.WriteLine(e.GetType().Name);
				throw new ServiceException("Error inesperado: " + e.Message);
			}
		}
	}
}