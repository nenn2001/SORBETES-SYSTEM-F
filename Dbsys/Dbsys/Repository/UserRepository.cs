﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys.AppData;
using Dbsys.DBSYSDataSet1TableAdapters;
using Dbsys.DBSYSDataSet2TableAdapters;

namespace Dbsys
{
    
    public class UserRepository
    {
        private DBSYSEntities1 db;
        public UserRepository()
        {
            db = new DBSYSEntities1();
        }

        public ErrorCode NewUser(UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.UserAccounts.Add(aUserAccount);
                db.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;


        
        
        }


        public ErrorCode UpdateUser(int? userId, UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                UserAccount user = db.UserAccounts.Where(m => m.userId == userId).FirstOrDefault();
                // Update the value of the retrieved user
                user.userName = aUserAccount.userName;
                user.userPassword = aUserAccount.userPassword;

                db.SaveChanges();       // Execute the update

                outMessage = "Updated";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Success;
                MessageBox.Show(ex.Message);
            }
            return retValue;

        }

        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                UserAccount user = db.UserAccounts.Where(m => m.userId == userId).FirstOrDefault();
                // Remove the user
                db.UserAccounts.Remove(user);
                db.SaveChanges();       // Execute the update

                outMessage = "Deleted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            db = new DBSYSEntities1();

            return db.UserAccounts.Where(m => m.userName == username).FirstOrDefault();
        }
        public List<UserAccount> UserAccounts()
        {
            db = new DBSYSEntities1();

            return db.UserAccounts.ToList();
        }

        public List<vw_addrole> AllUserRole() 
        {
            db = new DBSYSEntities1();

            return db.vw_addrole.ToList();

        }

        public List<SALESsold> SALESsolds()
        {
            db = new DBSYSEntities1();

            return db.SALESsolds.ToList();

        }
        public List<vw_Sales> vw_Sales()
        {
            db = new DBSYSEntities1();

            return db.vw_Sales.ToList();

        }
    }
}
