using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MugiwaraChat2._0
{
    internal class DataIO
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\amazi\\OneDrive\\Desktop\\C# coding\\Websites, Apps And Databases\\MugiwaraChat2.0\\MugiwaraChat2.0\\Chats.mdf\";Integrated Security=True");

        public void AddUser(string username, string password, string fn, string ln, byte[] pfp)
        {
            string insert = "INSERT INTO tbl_User(user_username, user_password, user_FN, user_LN, user_PFP) VALUES(@username, @pass, @fn, @ln, @pfp)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@pfp", pfp);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Signed Up Successfuly.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CheckAvailableUsername(string username)
        {
            string Find = "SELECT user_username FROM tbl_User where user_username = '" + username + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable checkLOGIN(string username, string password)
        {
            // Sql Parameter to avoid SQL Injection
            string findQuery = "SELECT * FROM tbl_User WHERE user_username = @username AND user_password = @password";
            SqlDataAdapter adapt = new SqlDataAdapter(findQuery, con);
                
            adapt.SelectCommand.Parameters.AddWithValue("@username", username);
            adapt.SelectCommand.Parameters.AddWithValue("@password", password);

            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;

        }
        
        public void updateStatus(string ID, int x)
        {
            if (x == 1)
            {
                string UPDATE = "UPDATE tbl_User SET user_Status = 1 WHERE user_ID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(UPDATE, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (x == 2)
            {
                string UPDATE = "UPDATE tbl_User SET user_Status = 0 WHERE user_ID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(UPDATE, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        public DataTable getOnlineFriends(string ID)
        {
            string Find = "SELECT * FROM tbl_Friends JOIN tbl_User ON tbl_User.user_ID = tbl_Friends.user_ID WHERE tbl_Friends.friend_ID = '" + ID + "' AND tbl_User.user_Status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public DataTable getOfflineFriends(string ID)
        {
            string Find = "SELECT * FROM tbl_Friends JOIN tbl_User ON tbl_User.user_ID = tbl_Friends.user_ID WHERE tbl_Friends.friend_ID = '" + ID + "' AND tbl_User.user_Status = 0";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public bool checkFriendRequest(string fromID, string toID)
        {
            string Find = "SELECT * FROM tbl_FriendRequest WHERE request_from_ID = '" + fromID + "' AND request_to_ID = '" + toID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void sendFriendRequest(int fromID, int toID, string username)
        {
            string Insert = "INSERT INTO tbl_FriendRequest(request_from_ID, request_to_ID) VALUES(@from, @to)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@from", fromID);
            cmd.Parameters.AddWithValue("@to", toID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Friend Request Sent To " + username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable getFriendRequests(string ID)
        {
            string Find = "SELECT * FROM tbl_FriendRequest JOIN tbl_User ON tbl_FriendRequest.request_from_ID = tbl_User.user_ID WHERE request_to_ID = '" + ID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public void acceptFriendRequest(int fromID, int toID)
        {
            string Insert = "INSERT INTO tbl_Friends(user_ID, friend_ID) VALUES(@from1, @to1) ; INSERT INTO tbl_Friends(user_ID, friend_ID) VALUES(@to2, @from2) ; DELETE FROM tbl_FriendRequest WHERE request_from_ID = '" + fromID + "' AND request_to_ID = '" + toID + "'";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@from1", fromID);
            cmd.Parameters.AddWithValue("@to1", toID);
            cmd.Parameters.AddWithValue("@from2", fromID);
            cmd.Parameters.AddWithValue("@to2", toID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RejectFriendRequest(int fromID, int toID)
        {
            string DELETE = "DELETE FROM tbl_FriendRequest WHERE request_from_ID = '" + fromID + "' AND request_to_ID = '" + toID + "'";
            SqlCommand cmd = new SqlCommand(DELETE, con);
            cmd.Parameters.AddWithValue("@from", fromID);
            cmd.Parameters.AddWithValue("@to", toID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable getSearchedUsers(string username)
        {
            string Find = "SELECT * FROM tbl_User WHERE user_username LIKE '" + username + "%' ";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public bool CheckFriends(string ID1, string ID2)
        {
            //string Find = "SELECT * FROM tbl_Friends JOIN tbl_User ON tbl_Friends.friend_ID = tbl_User.user_ID WHERE tbl_User.user_username LIKE '" + username + "%'";
            string Find = "SELECT * FROM tbl_Friends WHERE user_ID = '" + ID1 + "' AND friend_ID = '" + ID2 + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getAllFriends(string ID)
        {
            string Find = "SELECT * FROM tbl_User JOIN tbl_Friends ON tbl_User.user_ID = tbl_Friends.user_ID WHERE tbl_Friends.friend_ID = '" + ID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public void removeFriend(int ID1, int ID2)
        {
            string DELETE = "DELETE FROM tbl_Friends WHERE user_ID = '" + ID1 + "' AND friend_ID  = '" + ID2 + "' ; DELETE FROM tbl_Friends WHERE user_ID = '" + ID2 + "' AND friend_ID = '" + ID1 + "'";
            SqlCommand cmd = new SqlCommand(DELETE, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addNewChat(int ID1, int ID2)
        {
            string Insert = "INSERT INTO tbl_RecentChats(chat_From, chat_To) VALUES(@from1, @to1) ; INSERT INTO tbl_RecentChats(chat_From, chat_To) VALUES(@to2, @from2)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@from1", ID1);
            cmd.Parameters.AddWithValue("@to1", ID2);
            cmd.Parameters.AddWithValue("@from2", ID1);
            cmd.Parameters.AddWithValue("@to2", ID2);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool checkRecentChats(string ID1, string ID2)
        {
            string Find = "SELECT * FROM tbl_RecentChats WHERE chat_From = '" + ID1 + "' AND chat_To = '" + ID2 + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getRecentChats(string ID)
        {
            string Find = "SELECT * FROM tbl_RecentChats JOIN tbl_User ON tbl_RecentChats.chat_From = tbl_User.user_ID WHERE chat_To = '" + ID + "' ORDER BY tbl_User.user_Status DESC";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public void addPrivateMessage(int fromID, int ToID, string Message)
        {
            string Insert = "INSERT INTO tbl_PrivateMessages(message_FromID, message_ToID, message) VALUES(@from, @to, @message)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@from", fromID);
            cmd.Parameters.AddWithValue("@to", ToID);
            cmd.Parameters.AddWithValue("@message", Message);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable getPrivateMessages(string ID1, string ID2)
        {
            string Find = "SELECT * FROM tbl_PrivateMessages WHERE (message_FromID = '" + ID1 + "' AND message_ToID = '" + ID2 + "') OR (message_FromID = '" + ID2 + "' AND message_ToID = '" + ID1 + "') ORDER BY message_date ASC";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public void deleteRecentChat(int ID1, int ID2)
        {
            string DELETE = "DELETE FROM tbl_RecentChats WHERE chat_From = '" + ID1 + "' AND chat_To = '" + ID2 + "' ; DELETE FROM tbl_RecentChats WHERE chat_From = '" + ID2 + "' AND chat_To = '" + ID1 + "'";
            SqlCommand cmd = new SqlCommand(DELETE, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addGroupChat(int creatorID, string name, byte[] img)
        {
            string Insert = "INSERT INTO tbl_GroupChats(group_Name, group_CreatorID, group_IMG) VALUES(@name, @id, @img)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", creatorID);
            cmd.Parameters.AddWithValue("@img", img);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public DataTable getGroupChats(string ID)
        {
            string Find = "SELECT * FROM tbl_GroupChats JOIN tbl_GroupMembers ON tbl_GroupChats.group_ID = tbl_GroupMembers.group_ID WHERE tbl_GroupMembers.member_ID = '"+ID+"'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public DataTable getGroupMembers(string ID)
        {
            string Find = "SELECT * FROM tbl_GroupMembers JOIN tbl_User ON tbl_GroupMembers.member_ID = tbl_User.user_ID WHERE group_ID = '"+ID+"' ORDER BY tbl_User.user_Status DESC";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public DataTable checkGroupAdmin(string GroupID, string UserID)
        {
            string Find = "SELECT * FROM tbl_GroupMembers JOIN tbl_User ON tbl_GroupMembers.member_ID = tbl_User.user_ID WHERE group_ID = '" + GroupID + "' AND member_ID = '"+UserID+"'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public DataTable getOnlineMembers(string ID)
        {
            string Find = "SELECT* FROM tbl_User JOIN tbl_GroupMembers ON tbl_GroupMembers.member_ID = tbl_User.user_ID JOIN tbl_GroupChats ON tbl_GroupMembers.group_ID = tbl_GroupChats.group_ID WHERE tbl_GroupMembers.group_ID = '"+ID+"' AND tbl_User.user_Status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public void deleteUserFromGroup(int userID, int groupID) 
        {
            string DELETE = "DELETE FROM tbl_GroupMembers WHERE member_ID = '" + userID + "' AND group_ID = '" + groupID + "'";
            SqlCommand cmd = new SqlCommand(DELETE, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        public DataTable getGroupMessages(string groupID) 
        {
            string Find = "SELECT * FROM tbl_GroupMessages JOIN tbl_User ON tbl_GroupMessages.message_from_ID = tbl_User.user_ID WHERE message_group_ID = '" + groupID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public void addGroupMessage(int fromID, int GroupID, string Message)
        {
            string Insert = "INSERT INTO tbl_GroupMessages(message_from_ID, message_group_ID, message) VALUES(@from, @group, @message)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@from", fromID);
            cmd.Parameters.AddWithValue("@group", GroupID);
            cmd.Parameters.AddWithValue("@message", Message);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void setGroupAdmin(string groupID, string userID) 
        {
            string UPDATE = "UPDATE tbl_GroupMembers SET isAdmin = 1 WHERE member_ID = '" + userID + "' AND group_ID = '"+groupID+"'";
            SqlCommand cmd = new SqlCommand(UPDATE, con);
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable checkGroupCreator(string groupID) 
        {
            string Find = "SELECT * FROM tbl_GroupChats WHERE group_ID = '"+groupID+"'";
            SqlDataAdapter adapt = new SqlDataAdapter(Find, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void removeAdmin(string groupID, string userID) 
        {
            DataTable dt = checkGroupCreator(groupID);
            if (dt.Rows[0]["group_CreatorID"].ToString() == userID) 
            {
                MessageBox.Show("Cannot Remove Since They Are The Creator Of The Group...");
            }
            else 
            {
                string UPDATE = "UPDATE tbl_GroupMembers SET isAdmin = 0 WHERE member_ID = '" + userID + "' AND group_ID = '" + groupID + "'";
                SqlCommand cmd = new SqlCommand(UPDATE, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void removeMemberFromGroup(int groupID, int userID) 
        {
            string DELETE = "DELETE FROM tbl_GroupMembers WHERE group_ID = '" + groupID + "' AND member_ID = '" + userID + "'";
            SqlCommand cmd = new SqlCommand(DELETE, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addGroupMember(int userID, int groupID)
        {
            string Insert = "INSERT INTO tbl_GroupMembers(group_ID, member_ID) VALUES(@group, @member)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@group", groupID);
            cmd.Parameters.AddWithValue("@member", userID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
