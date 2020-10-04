using System;
using System.Collections.Generic;
using System.Text;

namespace Tela_01
{
    public class Contact
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Contact(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public override string ToString()
        {
            string result = "";
            result += "Nome: " + name + "\n";
            result += "Telefone: " + phone + "\n";
            result += "Email: " + email + "\n";

            return result;
        }
    }
}
