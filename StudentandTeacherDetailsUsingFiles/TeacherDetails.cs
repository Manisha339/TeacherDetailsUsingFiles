using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetailsUsingFiles
{
    abstract class TeacherDetails
    {
        public string Id;
        public string Name;
        public string ClassandSession;

        public abstract string GetId();
        public abstract string GetName();
        public abstract string GetClassAndSession();
        public abstract void SetValues(string id,string name, string classandsession);
        public abstract void UpdateDetails(string id, string name, string classandsession);
    }
}
