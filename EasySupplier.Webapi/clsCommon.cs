using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




//using System.Text;
//using System.Data.SqlClient;
//using System.Data;
//using System.ComponentModel;
//using System.IO;
//using System.Configuration;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;


namespace BoilerSupplier.Webapi
{
    public class clsCommon
    {

        private static SqlConnection con;
        private static SqlCommand com;
        private static string constr;


        private static void connection()
        {
            constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);


        }
        public static string ConnectionString
        {
            get
            {
                
                return System.Configuration.ConfigurationManager.AppSettings["getconn"];
            }
        }
        public static string WebServiceURL
        {
            get
            {
                
                return System.Configuration.ConfigurationManager.AppSettings["URL"];
            }
        }

      
        public static string MailHostName
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["HostName"];
            }
        }

        public static string UserName1
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["Username"];
            }
        }

        public static string MailFrom
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["MailFrom"];
            }
        }

        public static string Password1

        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["Password"];
            }
        }

        public static string BCCMailId
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["BCCMailId"];
            }
        }

        public static string Port
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["Port"];
            }
        }

        //OTP Generate -string OTP = Convert.ToString(clsCommon.RandomNumber(100001, 999999));
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        // Generate a random string with a given size  
        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password  
        public static string RandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }


        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;

        }
        public static void LogError(Exception ex)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);
            message += Environment.NewLine;
            message += string.Format("StackTrace: {0}", ex.StackTrace);
            message += Environment.NewLine;
            message += string.Format("Source: {0}", ex.Source);
            message += Environment.NewLine;
            message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            // string path = HttpContext.Current.Server.MapPath("~/ErrorLog/ErrorLog.txt");
            string path = "";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
                writer.Close();
            }
        }
        public static void ErrorStatus(string messagestatus)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;

            message += Environment.NewLine;
            //string path = HttpContext.Current.Server.MapPath("~/ErrorLog/ErrorStatus.txt");
            string path = "";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(messagestatus + message);
                writer.Close();
            }
        }
        public static void jsonStatus(string json)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;

            message += Environment.NewLine;
            //string path = HttpContext.Current.Server.MapPath("~/ErrorLog/jsonstring.txt");
            string path = "";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(json);
                writer.Close();
            }
        }
        public static string Sapapiurl
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["Sapapiurl"];
            }
        }
        public static string sapusername
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["sapusername"];
            }
        }
        public static string sappassword
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["sappassword"];
            }
        }
        public static string GSTapiurl
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["GSTapiurl"];
            }
        }


        //17-6-2019 vinod added
        public static string GSTusername
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["username"];
            }
        }
        public static string GSTpassword
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["password"];
            }
        }



        public static string GSTclient_id
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["client_id"];
            }
        }
        public static string GSTclient_secret
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["client_secret"];
            }
        }
        public static string GSTgrant_type
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["grant_type"];
            }
        }

        public static string ProxyURL
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ProxyURL"];
            }
        }




    
        public static DataTable GetNDADetails(string LoginEmailID)
        {
            DataTable dt = new DataTable();
            connection();



            DataSet dsItem = new DataSet();
            try
            {
                com = new SqlCommand("USP_GetNDADetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@LoginEmailID", LoginEmailID);
                var returnParam = new SqlParameter
                {
                    ParameterName = "@Error",
                    Direction = ParameterDirection.Output,
                    Size = 1000
                };
                com.Parameters.Add(returnParam);
                SqlDataAdapter da = new SqlDataAdapter(com);
                con.Open();
                da.Fill(dsItem);

                dt = dsItem.Tables["Table"];
                con.Close();

            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }

            finally
            {
                con.Close();
            }
            return dt;

        }


        public static DataTable GetFirstLastName(string SignUpID)
        {
            DataTable dt = new DataTable();
            connection();
            DataSet dsItem = new DataSet();
            try
            {
                com = new SqlCommand("USP_GetFirstLastName", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@LoginEmailID", SignUpID);
                var returnParam = new SqlParameter
                {
                    ParameterName = "@Error",
                    Direction = ParameterDirection.Output,
                    Size = 1000
                };
                com.Parameters.Add(returnParam);
                SqlDataAdapter da = new SqlDataAdapter(com);
                con.Open();
                da.Fill(dsItem);

                dt = dsItem.Tables["Table"];
                con.Close();

            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }

            finally
            {
                con.Close();
            }
            return dt;

        }

        public static DataTable GetFirstLastNameEmp(string SignUpID)
        {
            DataTable dt = new DataTable();
            connection();
            DataSet dsItem = new DataSet();
            try
            {
                com = new SqlCommand("USP_GetFirstLastNameEmp", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@LoginEmailID", SignUpID);
                var returnParam = new SqlParameter
                {
                    ParameterName = "@Error",
                    Direction = ParameterDirection.Output,
                    Size = 1000
                };
                com.Parameters.Add(returnParam);
                SqlDataAdapter da = new SqlDataAdapter(com);
                con.Open();
                da.Fill(dsItem);

                dt = dsItem.Tables["Table"];
                con.Close();

            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }

            finally
            {
                con.Close();
            }
            return dt;

        }



        public static DataTable GetNDAAppDetails(string vendorcode)
        {
            DataTable dt = new DataTable();
            connection();



            DataSet dsItem = new DataSet();
            try
            {
                com = new SqlCommand("USP_GetNDAAppDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@vendorcode", vendorcode);
                var returnParam = new SqlParameter
                {
                    ParameterName = "@Error",
                    Direction = ParameterDirection.Output,
                    Size = 1000
                };
                com.Parameters.Add(returnParam);
                SqlDataAdapter da = new SqlDataAdapter(com);
                con.Open();
                da.Fill(dsItem);

                dt = dsItem.Tables["Table"];
                con.Close();

            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }

            finally
            {
                con.Close();
            }
            return dt;

        }


         

        public enum PasswordScore
        {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }
        //public static int CheckStrength(string password)
        //{
        //    int score = 0;

        //    if (password.Length < 1)
        //        return 0;
        //    if (password.Length < 4)
        //        return 1;

        //    if (password.Length >= 8)
        //        score++;
        //    if (password.Length >= 12)
        //        score++;
        //    if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
        //        score++;
        //    if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
        //      Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
        //        score++;
        //    if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
        //        score++;

        //    return score;
        //}
        [Flags]
        public enum PasswordRules
        {
            /// <summary> /// Password must contain a digit /// </summary> 
            Digit = 1,
            /// /// <summary> /// Password must contain an uppercase letter /// </summary> 
            UpperCase = 2,
            /// /// <summary> /// Password must contain a lowercase letter /// </summary> 
            LowerCase = 4,
            /// /// <summary> /// Password must have both upper and lower case letters /// </summary> 
            MixedCase = 6,
            /// /// <summary> /// Password must include a non-alphanumeric character /// </summary>
            SpecialChar = 8,
            /// /// <summary> /// All rules should be checked /// </summary>
            All = 15,
            /// /// <summary> /// No rules should be checked /// </summary> 
            None = 0
        }

        public static bool IsPasswordValid(string password, PasswordRules rules, params string[] ruleOutList)
        {
            bool result = true;
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            string allChars = lower + upper + digits;
            //Check Lowercase if rule is enforced
            if (Convert.ToBoolean(rules & PasswordRules.LowerCase))
            {
                result &= (password.IndexOfAny(lower.ToCharArray()) >= 0);
            }
            //Check Uppercase if rule is enforced
            if (Convert.ToBoolean(rules & PasswordRules.UpperCase))
            {
                result &= (password.IndexOfAny(upper.ToCharArray()) >= 0);
            }
            //Check to for a digit in password if digit is required
            if (Convert.ToBoolean(rules & PasswordRules.Digit))
            {
                result &= (password.IndexOfAny(digits.ToCharArray()) >= 0);
            }
            //Check to make sure special character is included if required
            if (Convert.ToBoolean(rules & PasswordRules.SpecialChar))
            {
                result &= (password.Trim(allChars.ToCharArray()).Length > 0);
            }
            if (ruleOutList != null)
            {
                for (int i = 0; i < ruleOutList.Length; i++)
                    result &= (password != ruleOutList[i]);
            }
            return result;
        }

        public static string InValidpasswordmsg
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["passwordmsg"];
            }
        }

        public static int TimeOut
        {
            get
            {
                return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["timeout"]);
            }
        }


        public static DataTable GetEmpDetailsByADLogin(string ADLogin)
        {
            DataTable dt = new DataTable();
            connection();
            DataSet dsItem = new DataSet();
            try
            {
                com = new SqlCommand("USP_GetEmpDetailsByADLogin", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ADLogin", ADLogin);
                var returnParam = new SqlParameter
                {
                    ParameterName = "@Error",
                    Direction = ParameterDirection.Output,
                    Size = 1000
                };
                com.Parameters.Add(returnParam);
                SqlDataAdapter da = new SqlDataAdapter(com);
                con.Open();
                da.Fill(dsItem);

                dt = dsItem.Tables["Table"];
                con.Close();

            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }

            finally
            {
                con.Close();
            }
            return dt;

        }

        public static string ContactOTPSubject
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ContactOTPSubject"];
            }
        }

        //29-11-2019
        public static string InvitationOTPSubject
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["InvitationOTPSubject"];
            }
        }
        public static string RegistrationOTPSubject
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["RegistrationOTPSubject"];
            }
        }
        public static string LoginOTPSubject
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["LoginOTPSubject"];
            }
        }
        public static string QueriesSubject
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["QueriesSubject"];
            }
        }


     
        public static string BCCMailIdDef
        {
            get
            {

                return System.Configuration.ConfigurationManager.AppSettings["BCCMailIdDef"];
            }
        }

        public static int EmpRoleType
        {
            get
            {
                return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["EmpRoleType"]);
            }
        }

 

        public static DataTable GetMSMEDDate(string vendorcode)
        {
            DataTable dt = new DataTable();
            connection();



            DataSet dsItem = new DataSet();
            try
            {
                com = new SqlCommand("USP_GetMSMEDDate", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@vendorcode", vendorcode);
                var returnParam = new SqlParameter
                {
                    ParameterName = "@Error",
                    Direction = ParameterDirection.Output,
                    Size = 1000
                };
                com.Parameters.Add(returnParam);
                SqlDataAdapter da = new SqlDataAdapter(com);
                con.Open();
                da.Fill(dsItem);

                dt = dsItem.Tables["Table"];
                con.Close();

            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }

            finally
            {
                con.Close();
            }
            return dt;

        }

        //29-7-2021
        //public class AESEncrytDecry
        //{
        private static string DecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] iv)
        {
            // Check arguments.  
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }
            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }

            // Declare the string used to hold  
            // the decrypted text.  
            string plaintext = null;

            // Create an RijndaelManaged object  
            // with the specified key and IV.  
            using (var rijAlg = new RijndaelManaged())
            {
                //Settings  
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.FeedbackSize = 128;

                rijAlg.Key = key;
                rijAlg.IV = iv;

                // Create a decrytor to perform the stream transform.  
                var decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                try
                {
                    // Create the streams used for decryption.  
                    using (var msDecrypt = new MemoryStream(cipherText))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {

                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                // Read the decrypted bytes from the decrypting stream  
                                // and place them in a string.  
                                plaintext = srDecrypt.ReadToEnd();

                            }

                        }
                    }
                }
                catch
                {
                    plaintext = "keyError";
                }
            }

            return plaintext;
        }

        //private static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
        //{
        //    // Check arguments.  
        //    if (plainText == null || plainText.Length <= 0)
        //    {
        //        throw new ArgumentNullException("plainText");
        //    }
        //    if (key == null || key.Length <= 0)
        //    {
        //        throw new ArgumentNullException("key");
        //    }
        //    if (iv == null || iv.Length <= 0)
        //    {
        //        throw new ArgumentNullException("key");
        //    }
        //    byte[] encrypted;
        //    // Create a RijndaelManaged object  
        //    // with the specified key and IV.  
        //    using (var rijAlg = new RijndaelManaged())
        //    {
        //        rijAlg.Mode = CipherMode.CBC;
        //        rijAlg.Padding = PaddingMode.PKCS7;
        //        rijAlg.FeedbackSize = 128;

        //        rijAlg.Key = key;
        //        rijAlg.IV = iv;

        //        // Create a decrytor to perform the stream transform.  
        //        var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

        //        // Create the streams used for encryption.  
        //        using (var msEncrypt = new MemoryStream())
        //        {
        //            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        //            {
        //                using (var swEncrypt = new StreamWriter(csEncrypt))
        //                {
        //                    //Write all data to the stream.  
        //                    swEncrypt.Write(plainText);
        //                }
        //                encrypted = msEncrypt.ToArray();
        //            }
        //        }
        //    }

        //    // Return the encrypted bytes from the memory stream.  
        //    return encrypted;
        //}

        public static string DecryptStringAES(string cipherText, string aes_key, string aes_iv)
        {
            var keybytes = Encoding.UTF8.GetBytes(aes_key);
            var iv = Encoding.UTF8.GetBytes(aes_iv);

            var encrypted = Convert.FromBase64String(cipherText);
            var decriptedFromJavascript = DecryptStringFromBytes(encrypted, keybytes, iv);
            return string.Format(decriptedFromJavascript);
        }

        public static string EncryptStringAES(string plainText, string aes_key, string aes_iv)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(aes_key);
                aes.IV = Encoding.UTF8.GetBytes(aes_iv);

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }
        public static string GetMd5Hash(string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            using (MD5 md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public static bool VerifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        //}
    }
}
