﻿using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Fireman_Systemn.Controller
{
    public class CasesController
    {
        public List<Cases> GetAll()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var cases = fse.Cases.ToList();
                return cases;
            }
        }

        public void Insert(Cases Case)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                Case.Case_id = fse.Cases.Count() + 1;
                fse.Cases.Add(Case);
                fse.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var fireCase = fse.Cases.Where(c => c.Case_id == id).FirstOrDefault();
                if (fireCase != null)
                {
                    fse.Cases.Remove(fireCase);
                    fse.SaveChanges();
                }
            }
        }
    }
}