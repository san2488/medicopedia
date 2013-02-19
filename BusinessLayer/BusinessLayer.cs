using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DomainClassLayer;
using DataClassLayer;
using System.Data;
using System.Text.RegularExpressions;


namespace BusinessClassLayer
{
    public class BusinessLayer
    {
        public void DeleteDoctor(String docUsername, string connString)
        {
            SqlParameter dUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            dUsername.Value = docUsername;
            SqlCommand cmdSql = new SqlCommand();
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_DeleteDoctor";
            cmdSql.Parameters.Add(dUsername);
            DataLayer datalayerObj = new DataLayer();
            cmdSql = datalayerObj.Delete(cmdSql, connString);
        }

        public void DeleteUser(String UserUsername, string connString)
        {
            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            pUsername.Value = UserUsername;
            SqlCommand cmdSql2 = new SqlCommand();
            cmdSql2.CommandType = CommandType.StoredProcedure;
            cmdSql2.CommandText = "usp_DeleteUser";
            cmdSql2.Parameters.Add(pUsername);
            DataLayer datalayerObj = new DataLayer();
            cmdSql2 = datalayerObj.Delete(cmdSql2, connString);
        }

        public void ApproveDoctor(String docUsername, string connString)
        {
            SqlParameter dUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            dUsername.Value = docUsername;
            SqlCommand cmdSql = new SqlCommand();
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_ApproveDoctor";
            cmdSql.Parameters.Add(dUsername);
            DataLayer datalayerObj = new DataLayer();
            cmdSql = datalayerObj.Update(cmdSql, connString);
        }
        public PrescribedMedicine InsertPrescribedMedicine(PrescribedMedicine prescribedMedicineObj, string connString)
        {
            SqlParameter pMedicineName = new SqlParameter("@MedicineName", SqlDbType.NVarChar, 50);
            SqlParameter pPrescriptionId = new SqlParameter("@PrescriptionId", SqlDbType.Int, 50);
            SqlParameter pDosageBreakfast = new SqlParameter("@DosageBreakfast", SqlDbType.NVarChar, 7);
            SqlParameter pDosageLunch = new SqlParameter("@DosageLunch", SqlDbType.NVarChar, 7);
            SqlParameter pDosageDinner = new SqlParameter("@DosageDinner", SqlDbType.NVarChar, 7);
            SqlParameter pDays = new SqlParameter("@Days", SqlDbType.Int, 10);
            SqlParameter pNumberOfTablets = new SqlParameter("@NumberOfTablets", SqlDbType.Int, 10);

            //parmeter value intialization
            pMedicineName.Value = prescribedMedicineObj.MedicineName;
            pPrescriptionId.Value = prescribedMedicineObj.PrescriptionId;
            pDosageBreakfast.Value = prescribedMedicineObj.DosageBreakfast;
            pDosageLunch.Value = prescribedMedicineObj.DosageLunch;
            pDosageDinner.Value = prescribedMedicineObj.DosageDinner;
            pDays.Value = prescribedMedicineObj.Days;
            pNumberOfTablets.Value = prescribedMedicineObj.NumberOfTablets;


            SqlCommand cmdSql = new SqlCommand();
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_InsertPrescribedMedicines";
            cmdSql.Parameters.Add(pMedicineName);
            cmdSql.Parameters.Add(pPrescriptionId);
            cmdSql.Parameters.Add(pDosageBreakfast);
            cmdSql.Parameters.Add(pDosageLunch);
            cmdSql.Parameters.Add(pDosageDinner);
            cmdSql.Parameters.Add(pDays);
            cmdSql.Parameters.Add(pNumberOfTablets);
            DataLayer datalayerObj = new DataLayer();
            cmdSql = datalayerObj.Insert(cmdSql, connString);
            return prescribedMedicineObj;
        }

        public Prescriptions InsertPrescription(Prescriptions prescriptionsObj, string connString)
        {
            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            SqlParameter pPrescriptionDateTime = new SqlParameter("@PrescriptionDateTime", SqlDbType.DateTime);
            SqlParameter pQueryId = new SqlParameter("@QueryId", SqlDbType.NVarChar, 7);
            SqlParameter pPrescriptionId = new SqlParameter("@PrescriptionId", SqlDbType.Int);
            //parmeter value intialization
            pUsername.Value = prescriptionsObj.Username;
            pPrescriptionDateTime.Value = prescriptionsObj.PrescriptionDateTime;
            pQueryId.Value = prescriptionsObj.QueryId;
            pPrescriptionId.Direction = ParameterDirection.Output;

            SqlCommand cmdSql = new SqlCommand();
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_InsertPrescription_test";
            cmdSql.Parameters.Add(pUsername);
            cmdSql.Parameters.Add(pPrescriptionDateTime);
            cmdSql.Parameters.Add(pQueryId);
            cmdSql.Parameters.Add(pPrescriptionId);
            DataLayer datalayerObj = new DataLayer();
            cmdSql = datalayerObj.Insert(cmdSql, connString);
            prescriptionsObj.PrescriptionId = Convert.ToInt32(pPrescriptionId.Value);
            return prescriptionsObj;
        }

        public bool IsRegisteredUser(AuthTable user, string connString)
        {
            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            SqlParameter pResult = new SqlParameter("@Result", SqlDbType.Bit);

            pUsername.Value = user.Username;
            pPassword.Value = user.Password;
            pResult.Direction = ParameterDirection.Output;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_ValidateUserPassword";
            cmdSQL.Parameters.Add(pUsername);
            cmdSQL.Parameters.Add(pPassword);
            cmdSQL.Parameters.Add(pResult);

            DataLayer dataLayerObj = new DataLayer();
            cmdSQL = dataLayerObj.Select(cmdSQL, connString);
            return bool.Parse(pResult.Value.ToString());
        }

        public AuthTable GetUser(AuthTable user, string connString)
        {
            DataSet dsUser = GetUserData(user, connString);
            user.Role = int.Parse(dsUser.Tables[0].Rows[0][0].ToString());
            user.UserId = int.Parse(dsUser.Tables[0].Rows[0][1].ToString());
            return user;
        }

        private DataSet GetUserData(AuthTable user, string connString)
        {
            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            pUsername.Value = user.Username;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_SelectUserByUsername";
            cmdSQL.Parameters.Add(pUsername);

            DataLayer dataLayerObj = new DataLayer();
            DataSet ds = dataLayerObj.GetQuery(cmdSQL, connString);
            return ds;
        }
        public Users InsertUsers(Users user, AuthTable authUser, string connString)
        {
            string errorMessage = string.Empty;
            if (IsValidUserData(user, authUser, out errorMessage))
            {

                SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                SqlParameter pUserFullName = new SqlParameter("@UserFullName", SqlDbType.NVarChar, 100);
                SqlParameter pUserEmailId = new SqlParameter("@UserEmailId", SqlDbType.NVarChar, 100);
                SqlParameter pUserGender = new SqlParameter("@UserGender", SqlDbType.Bit);
                SqlParameter pUserDOB = new SqlParameter("@UserDOB", SqlDbType.SmallDateTime);
                SqlParameter pUserAreaOfInterest = new SqlParameter("@UserAreaOfInterest", SqlDbType.NVarChar, 100);

                SqlParameter pUsernameAuth = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                SqlParameter pRole = new SqlParameter("@Role", SqlDbType.Int);

                pUsername.Value = user.Username;
                pUserFullName.Value = user.UserFullName;
                pUserEmailId.Value = user.UserEmailId;
                pUserGender.Value = user.UserGender;
                pUserDOB.Value = user.UserDOB;
                pUserAreaOfInterest.Value = user.UserAreaOfInterest;

                pUsernameAuth.Value = user.Username;
                pPassword.Value = authUser.Password;
                pRole.Value = authUser.Role;

                SqlCommand cmdSQL = new SqlCommand();
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "usp_InsertAuthTable";
                cmdSQL.Parameters.Add(pUsernameAuth);
                cmdSQL.Parameters.Add(pPassword);
                cmdSQL.Parameters.Add(pRole);

                bool isUsernamePresent = IsUsernamePresent(authUser, connString);
                DataLayer dataLayerObj = new DataLayer();
                if (!isUsernamePresent)
                {
                    cmdSQL = dataLayerObj.Insert(cmdSQL, connString);
                }
                else
                {
                    errorMessage = "Username already Present." + "<br/>" + errorMessage;
                }
                

                cmdSQL = new SqlCommand();
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "usp_InsertUser";
                cmdSQL.Parameters.Add(pUsername);
                cmdSQL.Parameters.Add(pUserFullName);
                cmdSQL.Parameters.Add(pUserEmailId);
                cmdSQL.Parameters.Add(pUserGender);
                cmdSQL.Parameters.Add(pUserDOB);
                cmdSQL.Parameters.Add(pUserAreaOfInterest);

                if (!isUsernamePresent)
                {
                    cmdSQL = dataLayerObj.Insert(cmdSQL, connString);
                }
                else
                {
                    throw new Exception(errorMessage); ;

                }
            }
            else
            {
                throw new Exception(errorMessage);
            }
            return user;
        }
        public Doctor InsertDoctor(Doctor doctor, AuthTable authUser, string connString)
        {
            string errorMessage = string.Empty;
            if (IsValidDoctorData(doctor, authUser, out errorMessage))
            {
                SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                SqlParameter pDocFullName = new SqlParameter("@DocName", SqlDbType.NVarChar, 100);
                SqlParameter pDocEmailId = new SqlParameter("@DocEmailId", SqlDbType.NVarChar, 100);
                SqlParameter pDocGender = new SqlParameter("@DocGender", SqlDbType.Bit);
                SqlParameter pDocDOB = new SqlParameter("@DocDateOfBirth", SqlDbType.SmallDateTime);
                SqlParameter pDocLicNo = new SqlParameter("@DocLicenceNo", SqlDbType.Int);
                SqlParameter pDocAreaOfInterest = new SqlParameter("@DocAreaOfInterest", SqlDbType.NVarChar, 100);

                SqlParameter pUsernameAuth = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                SqlParameter pRole = new SqlParameter("@Role", SqlDbType.Int);

                pUsername.Value = doctor.Username;
                pDocFullName.Value = doctor.DocName;
                pDocEmailId.Value = doctor.DocEmailId;
                pDocGender.Value = doctor.DocGender;
                pDocDOB.Value = doctor.DocDateOfBirth;
                pDocLicNo.Value = doctor.DocLicenseNo;
                pDocAreaOfInterest.Value = doctor.DocAreaOfInterest;

                pUsernameAuth.Value = doctor.Username;
                pPassword.Value = authUser.Password;
                pRole.Value = authUser.Role;

                SqlCommand cmdSQL = new SqlCommand();
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "usp_InsertAuthTable";
                cmdSQL.Parameters.Add(pUsernameAuth);
                cmdSQL.Parameters.Add(pPassword);
                cmdSQL.Parameters.Add(pRole);

                DataLayer dataLayerObj = new DataLayer();
                bool isUsernamePresent = IsUsernamePresent(authUser, connString);
                if (!isUsernamePresent)
                {
                    cmdSQL = dataLayerObj.Insert(cmdSQL, connString);
                }
                else
                {
                    errorMessage = "Username already Present." + "<br/>" + errorMessage;
                }
                

                cmdSQL = new SqlCommand();
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "usp_InsertDoctor";
                cmdSQL.Parameters.Add(pUsername);
                cmdSQL.Parameters.Add(pDocFullName);
                cmdSQL.Parameters.Add(pDocEmailId);
                cmdSQL.Parameters.Add(pDocGender);
                cmdSQL.Parameters.Add(pDocDOB);
                cmdSQL.Parameters.Add(pDocLicNo);
                cmdSQL.Parameters.Add(pDocAreaOfInterest);

                if (!isUsernamePresent)
                {
                    cmdSQL = dataLayerObj.Insert(cmdSQL, connString);
                }
                else
                {
                    throw new Exception(errorMessage);
                }
            }
            else
            {
                throw new Exception(errorMessage);
            }
            return doctor;
        }

        private bool IsValidUserData(Users user, AuthTable authUser, out string message)
        {
            bool isValidUser = true;
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(user.Username.Trim()))
            {
                isValidUser = false;
                errorMessage += "Please enter Username." + "<br />";
            }
            else if (user.Username.Length > 50)
            {
                isValidUser = false;
                errorMessage += "Username can be upto 50 characters." + "<br />";
            }
            if (string.IsNullOrEmpty(user.UserFullName.Trim()))
            {
                isValidUser = false;
                errorMessage += "Please enter valid Full Name." + "<br />";
            }
            else if (user.UserFullName.Length > 100)
            {
                isValidUser = false;
                errorMessage += "Full name can be upto 100 characters." + "<br />";
            }
            DateTime date;
            bool isValidDate = DateTime.TryParse(user.UserDOB.ToString(), out date);
            if (!isValidDate)
            {
                isValidUser = false;
                errorMessage += "Please enter valid Date of Birth." + "<br />";
            }
            else if (date.CompareTo(DateTime.Now) >= 0)
            {
                isValidUser = false;
                errorMessage += "Please enter valid Date of Birth." + "<br />";
            }
            string emailRegex = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$";
            if(!Regex.IsMatch(user.UserEmailId,emailRegex))
            {
                isValidUser = false;
                errorMessage += "Please enter valid email-id (abc@xyz.com)" + "<br />";
            }
            if (string.IsNullOrEmpty(authUser.Password))
            {
                isValidUser = false;
                errorMessage += "Please enter valid Password." + "<br />";
            }
            message = errorMessage;
            return isValidUser;
        }

        private bool IsValidDoctorData(Doctor doctor, AuthTable authUser, out string message)
        {
            bool isValidDoctor = true;
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(doctor.Username.Trim()))
            {
                isValidDoctor = false;
                errorMessage += "Please enter Username." + "<br />";
            }
            else if (doctor.Username.Length > 50)
            {
                isValidDoctor = false;
                errorMessage += "Username can be upto 50 characters" + "<br />";
            }
            if (string.IsNullOrEmpty(doctor.DocName.Trim()))
            {
                isValidDoctor = false;
                errorMessage += "Please enter valid Full Name" + "<br />";
            }
            else if(doctor.DocName.Length>100)
            {
                isValidDoctor = false;
                errorMessage += "Full name can be upto 100 characters." + "<br />";
            }
            DateTime date;
            bool isValidDate = DateTime.TryParse(doctor.DocDateOfBirth.ToString(), out date);
            if (!isValidDate)
            {
                isValidDoctor = false;
                errorMessage += "Please enter valid Date of Birth." + "<br />";
            }
            else if (date.CompareTo(DateTime.Now) >= 0)
            {
                isValidDoctor = false;
                errorMessage += "Please enter valid Date of Birth." + "<br />";
            }
            string emailRegex = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$";
            if (!Regex.IsMatch(doctor.DocEmailId, emailRegex))
            {
                isValidDoctor = false;
                errorMessage += "Please enter valid email-id (abc@xyz.com)" + "<br />";
            }
            if (doctor.DocLicenseNo<1)
            {
                isValidDoctor = false;
                errorMessage += "Please enter valid licence number." + "<br />";
            }
            if (string.IsNullOrEmpty(authUser.Password.Trim()))
            {
                isValidDoctor = false;
                errorMessage += "Please enter valid Password." + "<br />";
            }
            message = errorMessage;
            return isValidDoctor;
        }

        private bool IsUsernamePresent(AuthTable authUser, string connString)
        {
            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            SqlParameter pResult = new SqlParameter("@Result", SqlDbType.Bit);

            pResult.Direction = ParameterDirection.Output;
            pUsername.Value = authUser.Username;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_IsUsernamePresent";

            cmdSQL.Parameters.Add(pUsername);
            cmdSQL.Parameters.Add(pResult);

            DataLayer dataLayerObj = new DataLayer();
            cmdSQL = dataLayerObj.Select(cmdSQL, connString);

            bool numUser = bool.Parse(pResult.Value.ToString());
            return numUser;
        }

        public void InsertComment(Comments commentObj, string connString)
        {
            string errormsg;
            try
            {
                if (IsValidComment(commentObj, out errormsg))
                {
                    SqlParameter pAdviceId = new SqlParameter("@AdviceId", SqlDbType.Int, 0);
                    SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                    SqlParameter pCommentsField = new SqlParameter("@CommentsField", SqlDbType.NVarChar, 400);
                    SqlParameter pCommentDateTime = new SqlParameter("CommentDateTime", SqlDbType.DateTime, 0);

                    pAdviceId.Value = commentObj.AdviceId;
                    pUsername.Value = commentObj.Username;
                    pCommentsField.Value = commentObj.CommentsField;
                    pCommentDateTime.Value = commentObj.CommentDateTime;

                    SqlCommand cmdSql = new SqlCommand();
                    cmdSql.CommandType = CommandType.StoredProcedure;
                    cmdSql.CommandText = "usp_InsertComment";
                    cmdSql.Parameters.Add(pAdviceId);
                    cmdSql.Parameters.Add(pUsername);
                    cmdSql.Parameters.Add(pCommentsField);
                    cmdSql.Parameters.Add(pCommentDateTime);

                    DataLayer datalayerObj = new DataLayer();
                    cmdSql = datalayerObj.Insert(cmdSql, connString);
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch
            {
                throw;
            }

        }


        public DataSet SelectAdvice(Advice adviceObj, string connString)
        {

            DataSet dsAdvice = new DataSet();
            SqlParameter pAdviceId = new SqlParameter("@AdviceId", SqlDbType.Int, 0);
            pAdviceId.Value = adviceObj.AdviceId;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_GetAdvice";
            cmdSQL.Parameters.Add(pAdviceId);
            DataLayer datalayerObj = new DataLayer();
            dsAdvice = datalayerObj.GetQuery(cmdSQL, connString);
            return dsAdvice;
        }

        public DataSet SelectQuery(Query queryObj, string connString)
        {

            DataSet dsQuery = new DataSet();
            SqlParameter pQueryId = new SqlParameter("@QueryId", SqlDbType.Int, 0);
            pQueryId.Value = queryObj.QueryId;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_GetQueryDetails";
            cmdSQL.Parameters.Add(pQueryId);
            DataLayer datalayerObj = new DataLayer();
            dsQuery = datalayerObj.GetQuery(cmdSQL, connString);
            return dsQuery;
        }

        public DataSet SelectComment(Comments commentObj, string connString)
        {

            DataSet dsComment = new DataSet();
            SqlParameter pAdviceId = new SqlParameter("@AdviceId", SqlDbType.Int, 0);
            pAdviceId.Value = commentObj.AdviceId;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_GetCommentDetails";
            cmdSQL.Parameters.Add(pAdviceId);
            DataLayer datalayerObj = new DataLayer();
            dsComment = datalayerObj.GetQuery(cmdSQL, connString);
            return dsComment;
        }

        public DataSet SelectTopTenAdvice(Query queryObj, string connString)
        {
            DataSet dsTopAdvice = new DataSet();
            SqlParameter pAreaOfInterest = new SqlParameter("@QueryAreaOfInterest", SqlDbType.NVarChar, 100);
            pAreaOfInterest.Value = queryObj.QueryAreaOfInterest;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_GetTopTenAdvice";
            cmdSQL.Parameters.Add(pAreaOfInterest);
            DataLayer dataLayerObj = new DataLayer();
            dsTopAdvice = dataLayerObj.GetQuery(cmdSQL, connString);
            return dsTopAdvice;
        }

        public DataSet GetXmlDetails(Advice adviceObj, string connString)
        {
            DataSet dsXmlDetails = new DataSet();
            SqlParameter pAdviceId = new SqlParameter("@AdviceId", SqlDbType.Int, 0);
            pAdviceId.Value = adviceObj.AdviceId;

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_GetAdviceDetails";
            cmdSQL.Parameters.Add(pAdviceId);
            DataLayer datalayerObj = new DataLayer();
            dsXmlDetails = datalayerObj.GetQuery(cmdSQL, connString);
            return dsXmlDetails;
        }

        public DataSet GetQueryDetailsByUsername(Query queryObj, string connString)
        {
            DataSet dsQuery = new DataSet();
            SqlParameter pQueryUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            SqlParameter pQueryStatus = new SqlParameter("@Status", SqlDbType.NVarChar, 20);
            pQueryUsername.Value = queryObj.Username;
            pQueryStatus.Value = "Needs More Info";

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_GetQueryByUsername";

            cmdSQL.Parameters.Add(pQueryUsername);
            cmdSQL.Parameters.Add(pQueryStatus);

            DataLayer datalayerObj = new DataLayer();
            dsQuery = datalayerObj.GetQuery(cmdSQL, connString);
            return dsQuery;
        }



        public DataSet GetQueryWithFurtherUserDetails(Query queryObj, string connString)
        {
            DataSet dsQuery = new DataSet();
            SqlParameter pQueryUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            SqlParameter pQueryStatus = new SqlParameter("@Status", SqlDbType.NVarChar, 20);
            pQueryUsername.Value = queryObj.Username;
            pQueryStatus.Value = "Needs More Info";

            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.CommandText = "usp_GetQueryWithFurtherUserDetail";
            cmdSQL.Parameters.Add(pQueryUsername);
            cmdSQL.Parameters.Add(pQueryStatus);
            DataLayer datalayerObj = new DataLayer();
            dsQuery = datalayerObj.GetQuery(cmdSQL, connString);
            return dsQuery;
        }

        public bool IsValidComment(Comments commentObj, out string message)
        {
            bool isValidComment = true;
            StringBuilder builderMessage = new StringBuilder();
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(commentObj.CommentsField))
            {
                isValidComment = false;
                errorMessage = "A blank comment cannot be submited.Please enter something";
                builderMessage.Append(errorMessage);
            }
            else if (commentObj.CommentsField.Length > 400)
            {
                isValidComment = false;
                errorMessage = "Comment should not exceed 100 words (400 chars)";
                builderMessage.Append(errorMessage);
            }
            message = builderMessage.ToString();
            return isValidComment;
        }

        public DataSet getQuerry(string disease, string connectionString)
        {
            SqlParameter paramdisease = new SqlParameter("@AreaOfInterest", SqlDbType.VarChar);
            paramdisease.Value = disease;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SearchQueryByAreaOfInterest";
            cmd.Parameters.Add(paramdisease);
            DataLayer dataLayerObj = new DataLayer();
            DataSet ds = new DataSet();

            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;


        }

        public DataSet getQuerryByMedicine(string medicine, string connectionString)
        {
            SqlParameter paramdisease = new SqlParameter("@MedicineName", SqlDbType.VarChar);
            paramdisease.Value = medicine;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_SearchQueryByMedicine";
            cmd.Parameters.Add(paramdisease);
            DataLayer dataLayerObj = new DataLayer();
            DataSet ds = new DataSet();

            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;


        }
        public DataSet getQuerryByDoctor(string doctor, string connectionString)
        {
            SqlParameter paramdoc = new SqlParameter("@DocName", SqlDbType.NVarChar);
            paramdoc.Value = doctor;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetQueryByDocId";
            cmd.Parameters.Add(paramdoc);
            DataLayer dataLayerObj = new DataLayer();
            DataSet ds = new DataSet();

            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;


        }

        public DataSet getQuerryBySymptoms(string Symptoms, string connectionString)
        {
            SqlParameter paramSymptoms = new SqlParameter("@Symptoms", SqlDbType.NVarChar);
            paramSymptoms.Value = Symptoms;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetQueryBySymptoms";
            cmd.Parameters.Add(paramSymptoms);
            DataLayer dataLayerObj = new DataLayer();
            DataSet ds = new DataSet();

            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;


        }
        public DataSet getDoctor(string connectionString)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_getDoctor";
            DataLayer dataLayerObj = new DataLayer();
            DataSet dsDoctor = new DataSet();

            dsDoctor = dataLayerObj.GetQuery(cmd, connectionString);
            return dsDoctor;
        }

        public DataSet getWorkList(bool isAttendedTo, Doctor doc, string connectionString)
        {
            SqlParameter paramIsAttendedTo = new SqlParameter("@IsAttendedTo", SqlDbType.Bit);
            SqlParameter paramUserName = new SqlParameter("@UserName", SqlDbType.VarChar);
            paramUserName.Value = doc.Username;
            paramIsAttendedTo.Value = isAttendedTo;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetQueryByIsAttended";
            cmd.Parameters.Add(paramIsAttendedTo);
            cmd.Parameters.Add(paramUserName);
            DataSet ds = new DataSet();
            DataLayer dataLayerObj = new DataLayer();
            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;

        }
        public DataSet getAdvice(int QueryId, string connectionString)
        {
            SqlParameter paramQueryId = new SqlParameter("@QueryId", SqlDbType.Int);
            paramQueryId.Value = QueryId;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetAdviceByQueryId";
            cmd.Parameters.Add(paramQueryId);
            DataSet ds = new DataSet();
            DataLayer dataLayerObj = new DataLayer();
            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;

        }
        public DataSet getPrescription(int queryId, string connectionString)
        {
            SqlParameter paramQueryId = new SqlParameter("@QueryId", SqlDbType.Int);
            paramQueryId.Value = queryId;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetPrescriptionByQueryId";
            cmd.Parameters.Add(paramQueryId);
            DataSet ds = new DataSet();
            DataLayer dataLayerObj = new DataLayer();
            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;
        }

        public void InsertVote(Vote voteObj, string connString)
        {
            //declaration of parameters
            SqlParameter pAdviceId = new SqlParameter("@AdviceId", SqlDbType.Int);
            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            SqlParameter pIsLiked = new SqlParameter("@IsLiked", SqlDbType.Bit, 2);

            //initialization of parameters

            pAdviceId.Value = voteObj.AdviceId;
            pUsername.Value = voteObj.Username;
            pIsLiked.Value = voteObj.Isliked;

            //adding params to query

            SqlCommand cmdSql = new SqlCommand();
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_InsertVote";

            cmdSql.Parameters.Add(pAdviceId);
            cmdSql.Parameters.Add(pUsername);
            cmdSql.Parameters.Add(pIsLiked);


            //storage in data layer

            DataLayer datalayerObj = new DataLayer();
            cmdSql = datalayerObj.Insert(cmdSql, connString);
            return;
        }

        public void UpdateQuery(Query queryObj, string connString)
        {
            SqlParameter pQueryId = new SqlParameter("@QueryId", SqlDbType.Int);
            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            SqlParameter pQueryAreaOfInterest = new SqlParameter("@QueryAreaOfInterest", SqlDbType.NVarChar, 100);
            SqlParameter pSymptoms = new SqlParameter("@Symptoms", SqlDbType.NVarChar, 200);
            SqlParameter pMedicalHistory = new SqlParameter("@MedicalHistory", SqlDbType.NVarChar, 500);
            SqlParameter pStatus = new SqlParameter("@Status", SqlDbType.NVarChar, 20);
            SqlParameter pIsAttendedTo = new SqlParameter("@IsAttendedTo", SqlDbType.Bit);
            SqlParameter pPostedDateTime = new SqlParameter("@PostedDateTime", SqlDbType.DateTime);

            pQueryId.Direction = ParameterDirection.Output;
            pQueryAreaOfInterest.Value = queryObj.QueryAreaOfInterest;
            pUsername.Value = queryObj.Username;
            pSymptoms.Value = queryObj.Symptoms;
            pMedicalHistory.Value = queryObj.MedicalHistory;
            pStatus.Value = queryObj.Status;

            //the boolean value
            pIsAttendedTo.Value = queryObj.IsAttendedTo;

            //the date time value
            pPostedDateTime.Value = queryObj.PostedDatetime;

            //adding params to query
            SqlCommand cmdSql = new SqlCommand();
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_UpdateQuery";

            cmdSql.Parameters.Add(pQueryAreaOfInterest);
            cmdSql.Parameters.Add(pUsername);
            cmdSql.Parameters.Add(pSymptoms);
            cmdSql.Parameters.Add(pMedicalHistory);
            cmdSql.Parameters.Add(pStatus);
            cmdSql.Parameters.Add(pIsAttendedTo);
            cmdSql.Parameters.Add(pPostedDateTime);
            cmdSql.Parameters.Add(pQueryId);

            DataLayer datalayerObj = new DataLayer();
            datalayerObj.Update(cmdSql, connString);
            queryObj.QueryId = int.Parse(pQueryId.Value.ToString());
        }
        //update query status to needs more info

        public void UpdateQueryStatus(int queryId, string connString)
        {
            SqlParameter pQueryId = new SqlParameter("@QueryId", SqlDbType.Int);
            SqlParameter pQueryStatus = new SqlParameter("@Status", SqlDbType.VarChar, 30);
            pQueryId.Value = queryId;
            pQueryStatus.Value = "Needs More Info";

            SqlCommand cmdSql = new SqlCommand();

            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_UpdateQueryStatus";

            cmdSql.Parameters.Add(pQueryId);

            DataLayer dataLayerObj = new DataLayer();
            dataLayerObj.Update(cmdSql, connString);
        }
        public DataSet GetQuery(int queryId, string connString)
        {
            SqlParameter pQueryId = new SqlParameter("@QueryId", SqlDbType.Int);

            pQueryId.Value = queryId;

            SqlCommand cmdSql = new SqlCommand();
            cmdSql.CommandType = CommandType.StoredProcedure;
            cmdSql.CommandText = "usp_GetQueryById";

            cmdSql.Parameters.Add(pQueryId);

            DataLayer dataLayerObj = new DataLayer();
            DataSet ds = new DataSet();
            ds = dataLayerObj.GetQuery(cmdSql, connString);

            return ds;
        }

        public Advice InsertAdvice(Advice adviceObj, string connString)
        {
            //declaration of parameters
            string errorMessage;

            if (isValidAdvice(adviceObj, out errorMessage))
            {
                SqlParameter pQueryId = new SqlParameter("@QueryId", SqlDbType.Int);
                SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                SqlParameter pLikes = new SqlParameter("@Likes", SqlDbType.Int);
                SqlParameter pDislikes = new SqlParameter("@Dislikes", SqlDbType.Int);
                SqlParameter pAdviceDescription = new SqlParameter("@AdviceDescription", SqlDbType.NVarChar, 400);
                SqlParameter pAdviceTitle = new SqlParameter("@AdviceTitle", SqlDbType.NVarChar, 50);
                SqlParameter pAdviceDateTime = new SqlParameter("@AdviceDateTime", SqlDbType.DateTime);

                //initialization
                pQueryId.Value = adviceObj.QueryId;
                pUsername.Value = adviceObj.Username;
                pLikes.Value = adviceObj.Likes;
                pDislikes.Value = adviceObj.Dislikes;
                pAdviceDescription.Value = adviceObj.AdviceDescription;
                pAdviceTitle.Value = adviceObj.AdviceTitle;
                pAdviceDateTime.Value = adviceObj.AdviceDateTime;

                //adding params to query
                SqlCommand cmdSql = new SqlCommand();
                cmdSql.CommandType = CommandType.StoredProcedure;
                cmdSql.CommandText = "usp_InsertAdvice";

                cmdSql.Parameters.Add(pQueryId);
                cmdSql.Parameters.Add(pUsername);
                cmdSql.Parameters.Add(pLikes);
                cmdSql.Parameters.Add(pDislikes);
                cmdSql.Parameters.Add(pAdviceDescription);
                cmdSql.Parameters.Add(pAdviceTitle);
                cmdSql.Parameters.Add(pAdviceDateTime);

                //storage in data layer
                DataLayer datalayerObj = new DataLayer();
                cmdSql = datalayerObj.Insert(cmdSql, connString);


                //updating query status 'IsAttendedTo'
                SqlParameter pIsAttendedTo = new SqlParameter("@IsAttendedTo", SqlDbType.Bit);
                SqlParameter pStatus = new SqlParameter("@Status", SqlDbType.VarChar, 30);
                SqlParameter pQuery1 = new SqlParameter("@QueryId", SqlDbType.Int);
                pQuery1.Value = pQueryId.Value;
                pIsAttendedTo.Value = true;
                pStatus.Value = "Answered";

                //first command
                SqlCommand cmdSql1 = new SqlCommand();

                cmdSql1.CommandType = CommandType.StoredProcedure;
                cmdSql1.CommandText = "usp_UpdateQueryAttended";

                cmdSql1.Parameters.Add(pQuery1);
                cmdSql1.Parameters.Add(pIsAttendedTo);

                datalayerObj = new DataLayer();
                cmdSql1 = datalayerObj.Update(cmdSql1, connString);

                //second command
                SqlCommand cmdSql2 = new SqlCommand();
                cmdSql2.CommandType = CommandType.StoredProcedure;
                cmdSql2.CommandText = "usp_UpdateQueryStatus";

                cmdSql2.Parameters.Add(pStatus);

                datalayerObj = new DataLayer();
                cmdSql2 = datalayerObj.Update(cmdSql2, connString);
            }

            else
            {
                throw new Exception(errorMessage);
            }
            return adviceObj;
        }
        public Boolean isValidAdvice(Advice adviceObj, out string errorMessage)
        {
            errorMessage = "";

            if (adviceObj.AdviceTitle == "")
            {
                errorMessage += "Please enter advice title" + "<br/>";
            }

            if (adviceObj.AdviceDescription == "")
            {
                errorMessage += "Please enter advice description";

            }



            if (errorMessage.Equals(""))
                return true;

            else
                return false;
        }
        //insert Query
        public Query InsertQuery(Query queryObj, string connString)
        {
            string errorMessage;
            //declaration of parameters
            if (isValidQuery(queryObj, out errorMessage))
            {
                SqlParameter pQueryId = new SqlParameter("@QueryId", SqlDbType.Int);
                SqlParameter pQueryAreaOfInterest = new SqlParameter("@QueryAreaOfInterest", SqlDbType.NVarChar, 100);
                SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                SqlParameter pSymptoms = new SqlParameter("@Symptoms", SqlDbType.NVarChar, 50);
                SqlParameter pMedicalHistory = new SqlParameter("@MedicalHistory", SqlDbType.NVarChar, 500);
                SqlParameter pStatus = new SqlParameter("@Status", SqlDbType.NVarChar, 20);
                SqlParameter pIsAttendedTo = new SqlParameter("@IsAttendedTo", SqlDbType.Bit);
                SqlParameter pPostedDateTime = new SqlParameter("@PostedDateTime", SqlDbType.DateTime);

                //initialization

                //strings
                pQueryId.Direction = ParameterDirection.Output;
                pQueryAreaOfInterest.Value = queryObj.QueryAreaOfInterest;
                pUsername.Value = queryObj.Username;
                pSymptoms.Value = queryObj.Symptoms;
                pMedicalHistory.Value = queryObj.MedicalHistory;
                pStatus.Value = queryObj.Status;

                //the boolean value
                pIsAttendedTo.Value = queryObj.IsAttendedTo;

                //the date time value
                pPostedDateTime.Value = queryObj.PostedDatetime;

                //adding params to query
                SqlCommand cmdSql = new SqlCommand();
                cmdSql.CommandType = CommandType.StoredProcedure;
                cmdSql.CommandText = "usp_InsertQuery";

                cmdSql.Parameters.Add(pQueryAreaOfInterest);
                cmdSql.Parameters.Add(pUsername);
                cmdSql.Parameters.Add(pSymptoms);
                cmdSql.Parameters.Add(pMedicalHistory);
                cmdSql.Parameters.Add(pStatus);
                cmdSql.Parameters.Add(pIsAttendedTo);
                cmdSql.Parameters.Add(pPostedDateTime);
                cmdSql.Parameters.Add(pQueryId);

                //storage in data layer
                DataLayer datalayerObj = new DataLayer();
                datalayerObj.Insert(cmdSql, connString);
                queryObj.QueryId = int.Parse(pQueryId.Value.ToString());
            }
            else
            {
                throw new Exception(errorMessage);
            }

            //queryObj.QueryId = int.Parse(cmdSql.Parameters["@QueryId"].Value.ToString());
            return queryObj;
        }
        public Boolean isValidQuery(Query queryObj, out string errorMessage)
        {
            if (queryObj.MedicalHistory == "")
            {
                errorMessage = "Please enter medical history";
                return false;
            }

            errorMessage = "";
            return true;
        }
        public DataSet getComments(Comments commentObj, string connectionString)
        {
            SqlParameter pCommentId = new SqlParameter("@CommentId", SqlDbType.Int, 0);
            pCommentId.Value = commentObj.CommentId;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_GetCommentInfo";
            cmd.Parameters.Add(pCommentId);
            DataSet ds = new DataSet();
            DataLayer dataLayerObj = new DataLayer();
            ds = dataLayerObj.GetQuery(cmd, connectionString);
            return ds;
        }


        public void UpdateComment(Comments commentObj, string connectionString)
        {
            SqlParameter pCommentId = new SqlParameter("@CommentId", SqlDbType.Int, 0);
            SqlParameter pCommentField = new SqlParameter("@CommentsField", SqlDbType.NVarChar, 100);
            pCommentId.Value = commentObj.CommentId;
            pCommentField.Value = commentObj.CommentsField;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_UpdateUserSubmittedComment";
            cmd.Parameters.Add(pCommentId);
            cmd.Parameters.Add(pCommentField);
            DataLayer dataLayerObj = new DataLayer();
            cmd = dataLayerObj.Update(cmd, connectionString);
        }

    }

}
