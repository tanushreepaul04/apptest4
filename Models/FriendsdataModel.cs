using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace friends_db_service.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public String UserName { get; set; }
        public String UserEmail { get; set; }
        public String UserImage { get; set; }
    }

    public class Friends
    {
        [Key]
        public int FriendShipID { get; set; }
        public int UserID { get; set; }
        public int FriendUserID { get; set; }
        public int InviteSent { get; set; }
        public int InviteAccepted { get; set; }
    }

    public class Sharedproducts
    {
        [Key]
        public int ShareProductID { get; set; }
        public String ProductID { get; set; }
        public int SharedByUserID { get; set; }
        public int SharedToUserID { get; set; }
        public int Liked { get; set; }
        public int Rating { get; set; }
    }
}