using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class webSite
    {
        private string siteName { get; set; }
        private string siteUrl { get; set; }  
        private string siteDiscription { get; set; }
        private string ipAddress { get; set; }

        public void setIpAddress(string ip)
        {
            this.ipAddress = ip;
        }

        public void setUrl(string Url)
        {
            this.siteUrl = Url;
        }

        public string getIpAddress()
        {
            return "Ip сайта: " + this.ipAddress;
        }

        public string getUrl()
        {
            return "Url сайта: " + this.siteUrl;
        }

    }

    internal class Journal
    {
        public string name { get; set; }
        public string releaseDate { get; set; }

        public string descreaption { get; set; }

        private string phoneNumber { get; set; }
        
        private string email { get; set; }

        public void setNewName(string name)
        {
            this.name = name;
        }

        public string getPhoneNumber() 
        { 
            return "Контактный номер: " + this.phoneNumber;
        }

        public string getEmail()
        {
            return "Email журнала: " + this.email;
        }

    }

    internal class Shop
    {
        public string name { get; set; }
        public string address { get; set; }
        public string profileDescription { get; set; }
        private string phoneNumber { get; set; }
        private string email { get; set; }

        public void setNewName(string name)
        {
            this.name = name;
        }

        public string getPhoneNumber() { return "Контактный номер: " + this.phoneNumber; }

        public string getEmail() { return "Email магазина: " + this.email; }
    }

}
