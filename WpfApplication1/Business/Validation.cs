using System.Windows.Controls;

namespace LPLSystems.Business
{
    class Validation
    {
        public static bool passwordMatch(PasswordBox pb1, PasswordBox pb2)
        {
            if (pb1.Password == pb2.Password && pb1.Password != string.Empty)
            {
                return true;
            }
            else
                return false;
        }

        public static bool feildNotEmpty(TextBox tb)
        {
            if (tb.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
