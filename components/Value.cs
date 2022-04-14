using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceh_lab_inv.components
{
    internal class Value
    {

        // Connection values

        public string server_name = "localhost";
        public string server_user = "root";
        public string server_pass = "";
        public string server_port = "3307";
        public string db_name = "ceh_lab_inv_db";

        // User values

        public static int user_primary_id;
        public int UserPrimaryID
        {
            get { return user_primary_id; }
            set { user_primary_id = value; }
        }

        public static byte[] user_profile_picture;
        public byte[] UserProfilePicture
        {
            get { return user_profile_picture; }
            set { user_profile_picture = value; }
        }

        public static string user_first_name;
        public string UserFirstName
        {
            get { return user_first_name; }
            set { user_first_name = value; }
        }

        public static string user_middle_name;
        public string UserMiddleName
        {
            get { return user_middle_name; }
            set { user_middle_name = value; }
        }

        public static string user_last_name;
        public string UserLastName
        {
            get { return user_last_name; }
            set { user_last_name = value; }
        }

        public static int user_age;
        public int UserAge
        {
            get { return user_age; }
            set { user_age = value; }
        }

        public static string user_gender;
        public string UserGender
        {
            get { return user_gender; }
            set { user_gender = value; }
        }

        public static string user_address;
        public string UserAddress
        {
            get { return user_address; }
            set { user_address = value; }
        }

        public static DateTime user_birthday;
        public DateTime UserBirthday
        {
            get { return user_birthday; }
            set { user_birthday = value; }
        }

        public static string user_cellphone_number;
        public string UserCellphoneNumber
        {
            get { return user_cellphone_number; }
            set { user_cellphone_number = value; }
        }

        public static string user_telephone_number;
        public string UserTelephoneNumber
        {
            get { return user_telephone_number; }
            set { user_telephone_number = value; }
        }

        public static string user_email;
        public string UserEmail
        {
            get { return user_email; }
            set { user_email = value; }
        }

        public static string user_username;
        public string UserUsername
        {
            get { return user_username; }
            set { user_username = value; }
        }

        public static string user_password;
        public string UserPassword
        {
            get { return user_password; }
            set { user_password = value; }
        }

        public static string user_role;
        public string UserRole
        {
            get { return user_role; }
            set { user_role = value; }
        }

        // Supply values

        public static int supply_primary_id;
        public int SupplyPrimaryID
        {
            get { return supply_primary_id; }
            set { supply_primary_id = value; }
        }

        public static DateTime supply_arrival_date;
        public DateTime SupplyArrivalDate
        {
            get { return supply_arrival_date; }
            set { supply_arrival_date = value; }
        }

        public static DateTime supply_expiration_date;
        public DateTime SupplyExpirationDate
        {
            get { return supply_expiration_date; }
            set { supply_expiration_date = value; }
        }

        public static string supply_quantity;
        public string SupplyQuantity
        {
            get { return supply_quantity; }
            set { supply_quantity = value; }
        }

        public static string supply_item;
        public string SupplyItem
        {
            get { return supply_item; }
            set { supply_item = value; }
        }

        public static string supply_brand;
        public string SupplyBrand
        {
            get { return supply_brand; }
            set { supply_brand = value; }
        }

        public static string supply_qty;
        public string SupplyQty
        {
            get { return supply_qty; }
            set { supply_qty = value; }
        }

        public static string supply_supplier;
        public string SupplySupplier
        {
            get { return supply_supplier; }
            set { supply_supplier = value; }
        }

        public static string supply_unit_cost;
        public string SupplyUnitCost
        {
            get { return supply_unit_cost; }
            set { supply_unit_cost = value; }
        }

        public static int supply_number_of_unit;
        public int SupplyNumberOfUnit
        {
            get { return supply_number_of_unit; }
            set { supply_number_of_unit = value; }
        }

        public static string supply_total_cost;
        public string SupplyTotalCost
        {
            get { return supply_total_cost; }
            set { supply_total_cost = value; }
        }

        public static string supply_exp_rgt_cost;
        public string SupplyExpRgtCost
        {
            get { return supply_exp_rgt_cost; }
            set { supply_exp_rgt_cost = value; }
        }
    }
}
