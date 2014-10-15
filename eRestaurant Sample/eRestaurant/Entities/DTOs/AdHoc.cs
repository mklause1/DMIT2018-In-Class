using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities.DTOs
{
    // A delegate is a reference to a method
    public delegate Grade GradeConverter(int percent);

    public enum Grade
    {
        A, B, C, D, F
    }

    public class AdHoc : IAdHoc // This class implements IAdHoc interface
    {
        //A class has fields, properties, constructors and methods

        public bool IsHonours(GradeConverter callback)
        {
            Grade result = callback(75);
            return IsHonours(result);
        }

        public Grade ConvertToGrade(int percent)
        {
            Grade result = Grade.A;
                if (percent >= 80)
                {
                    result = Grade.A;
                }//end if

                return result;
        }

        public bool IsHonours(Grade value)
        {
            if (value == Grade.A)
            {
                return true;
            }//end if

            else
            {
                return false;
            }//end else

        }

        public string AsText(int value)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    }

    public interface IAdHoc
    {
        // An interface has properties and methods
        // Properties and methods do NOT have an implementation in an interface
        string AsText(int value);
        int Count { get; } // Properties can have a get, set or both
    }

}
