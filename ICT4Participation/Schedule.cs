using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Participation
{
    class Schedule
    {
        private string monday;
        private string tuesday;
        private string wednesday;
        private string thursday;
        private string friday;
        private string saturday;
        private string sunday;

        public string Monday
        {
            get { return monday; }
            set { monday = value; }
        }
        public string Tuesday
        {
            get { return tuesday; }
            set { tuesday = value; }
        }
        public string Wednesday
        {
            get { return wednesday; }
            set { wednesday = value; }
        }
        public string Thursday
        {
            get { return thursday; }
            set { thursday = value; }
        }
        public string Friday
        {
            get { return friday; }
            set { friday = value; }
        }
        public string Saturday
        {
            get { return saturday; }
            set { saturday = value; }
        }

        public string Sunday
        {
            get { return sunday; }
            set { sunday = value; }
        }
        public Schedule(string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string sunday)
        {
            this.monday = monday;
            this.tuesday = tuesday;
            this.wednesday = wednesday;
            this.thursday = thursday;
            this.friday = friday;
            this.saturday = saturday;
            this.sunday = sunday;
        }
    }
}
