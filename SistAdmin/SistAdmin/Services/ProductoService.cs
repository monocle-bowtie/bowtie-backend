﻿using SistAdmin.Models;
using log4net;
using Mastercard.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistAdmin.Services
{
    public class ProductoService : BaseService
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(ProductoService));

        // GET api/ProductoService
        public List<Producto> getAll()
        {
            return this.db.Producto.ToList();
        }

        // GET api/ProductoService/5
        public Producto find(long? id)
        {
            return this.db.Producto.Find(id);
        }

        // POST api/ProductoService
        public Producto saveOrUpdate(Producto p)
        {
            if (p.idProducto > 0)
            {
                db.Entry(p).State = EntityState.Modified;
            }
            else
            {
                p = this.db.Producto.Add(p);
            }
            this.save();

            return p;
        }

     /*   // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }
        */
        // DELETE api/<controller>/5
        public void delete(long id)
        {
            Producto p = this.db.Producto.Find(id);
            this.db.Producto.Remove(p);
            this.save();
        }
    }
}