using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicNovelSys
{
    
    class currentUser
    {
        private static int MemId;
        private static string uName;
        private static string fName;
        private static string lName;
        private static string email;
        private static float credit;
        private static string password;
        private static char categoryCode;

        public currentUser()
        {
            MemId = 0;
            uName = null;
            fName = null;
            lName = null;
            email = null;
            credit = 0;
            password = null;
            categoryCode = '\0';
        }
        public currentUser(int MemId, string uName, string fName, string lName, string email,
                           float credit, string password, char categoryCode)
        {
            SetMemId(MemId);
            SetUName(uName);
            SetFName(fName);
            SetLName(lName);
            SetEmail(email);
            SetCredit(credit);
            SetPassword(password);
            SetCategoryCode(categoryCode);
        }

        public static void SetMemId(int newMemId){
            MemId = newMemId;
        }
        public static void SetUName(string newuName)
        {
            uName = newuName;
        }
        public static void SetFName(string newfName)
        {
            fName = newfName;
        }
        public static void SetLName(string newlName)
        {
            lName = newlName;
        }
        public static void SetEmail(string newemail)
        {
            email = newemail;
        }
        public static void SetCredit(float newCredit)
        {
            credit = newCredit;
        }
        public static void SetPassword(string newpassword)
        {
            password = newpassword;
        }
        public static void SetCategoryCode(char newcategoryCode)
        {
            categoryCode = newcategoryCode;
        }



        public static int GetMemId() { return MemId; }
        public static string GetUName() { return uName; }
        public static string GetFName() { return fName; }
        public static string GetLName() { return lName; }
        public static string GetEmail() { return email; }
        public static float GetCredit() { return credit; }
        public static string GetPassword() { return password; }
        public static char GetCategoryCode() { return categoryCode; }


    }

}
