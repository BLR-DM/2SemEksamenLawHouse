﻿using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    
    public class ClientDbAccess
    {
        LawHouseDbContext db;
        public ClientDbAccess()
        {
            db = new LawHouseDbContext();
        }
        
        public void Create(Client client)
        {
            try
            {
                db.Add(client);
                db.SaveChanges();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
