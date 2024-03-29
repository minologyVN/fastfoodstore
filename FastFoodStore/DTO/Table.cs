﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class Table
    {
        private int id;
        private string name;
        private string status;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Table(int id , string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
        //public Table()
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Status = status;
        //}
        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
    }
}
