using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvMauAzil.Models
{
    public abstract class Uposlenik
    {
        static Int32 globalId = 0;
        Int32 employeeId;
        String imeUposlenika;
        long jmbgUposlenika;
        String usernameUposlenika;
        String passwordUposlenika;
        String emailUposlenika;

        protected Uposlenik(string imeUposlenika, long jmbgUposlenika, string usernameUposlenika, string passwordUposlenika, string emailUposlenika)
        {
            //if (ContainerClass.containsId(globalId + 1)) globalId = ContainerClass.brojUposlenih();
            globalId++;
            this.employeeId = globalId;
            this.imeUposlenika = imeUposlenika;
            this.jmbgUposlenika = jmbgUposlenika;
            this.usernameUposlenika = usernameUposlenika;
            this.passwordUposlenika = passwordUposlenika;
            this.emailUposlenika = emailUposlenika;
        }

        public static int GlobalId { get => globalId; set => globalId = value; }
        public string ImeUposlenika { get => imeUposlenika; set => imeUposlenika = value; }
        public long JmbgUposlenika { get => jmbgUposlenika; set => jmbgUposlenika = value; }
        public string UsernameUposlenika { get => usernameUposlenika; set => usernameUposlenika = value; }
        public string PasswordUposlenika { get => passwordUposlenika; set => passwordUposlenika = value; }
        public string EmailUposlenika { get => emailUposlenika; set => emailUposlenika = value; }
        public int EmployeeId { get => employeeId; }
        public string VrstaPosla { get => dajVrstuPosla(); }

        public abstract string dajVrstuPosla();
    }
}
