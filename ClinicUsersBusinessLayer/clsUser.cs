using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicUsersDataAccessLayer;
using ClinicPersonBusinessLayer;

namespace ClinicUsersBusinessLayer
{
    public class clsUser 
    {
        enum enMode { Update = 0, AddNew = 1 };
        enMode Mode = enMode.AddNew;

       // public int CurrentID = 0;
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
        public clsUser()
        {
            ID = -1;
            Name = "";
            UserName = "";
            Password = "";
            Permission = 0;
            Mode = enMode.AddNew;
        }

        clsUser(int iD,string name, string userName, string password, int permission)
        {
            ID = iD;
            Name = name;
            UserName = userName;
            Password = password;
            Permission = permission;
            Mode = enMode.Update;
        }
        public static bool DeleteUser(int UserID)
        {
            return (clsUserData.DeleteUser(UserID));
        }

        bool _AddNewUser()
        {
            this.ID = clsUserData.AddNewUser(this.UserName,this.Name, this.Password, this.Permission);
            return (this.ID != -1);
        }

        bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.ID, this.UserName, this.Name, this.Password, this.Permission);
        }
        public static bool IsUserExists(int UserID)
        {
            return clsUserData.IsUserExists(UserID);
        }
        public static DataTable GetAllUsersData()
        {
            return clsUserData.GetAllUsersData();
        }

        public static clsUser FindUser(int UserID)
        {
            string UserName = "";
            string Name = "";
            string Password = "";
            int Permission = 0;

            if (clsUserData.FindUser(UserID, ref UserName,ref Name, ref Password, ref Permission))
            {
                return new clsUser(UserID,  Name,UserName, Password, Permission);

            }
            return null;
        }

        public static clsUser FindUserByUserName(string UserName)
        {
            int UserID = -1;
            string Name = "";
            string Password = "";
            int Permission = 0;

            if (clsUserData.FindUser(ref UserID, UserName,ref Name, ref Password, ref Permission))
            {
                return new clsUser(UserID, Name, UserName, Password, Permission);

            }
            return null;
        }

        public static clsUser FindUserByName(string UserName1)
        {
            int UserID = -1;
            string UserName = UserName1;
            string Name = "";
            string Password = "";
            int Permission = 0;

            if (clsUserData.FindUserByName(ref UserID,  UserName,ref  Name, ref Password, ref Permission))
            {
                return new clsUser(UserID, Name, UserName, Password, Permission);

            }
            return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
    }
}

