-- Start of User

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `user_get`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `user_get` (Pid INT)
BEGIN
	SELECT ceh_lab_inv_db.users.id, profile_picture, first_name, middle_name, last_name, age, gender, address, birthday, cellphone_number, telephone_number,
    email, username, CAST(AES_DECRYPT(password, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), role FROM ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = 
    ceh_lab_inv_db.accounts.id WHERE ceh_lab_inv_db.users.id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `user_add`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `user_add` (Pprofile_picture BLOB, Pfirst_name VARCHAR(255), Pmiddle_name VARCHAR(255), Plast_name VARCHAR(255),
Page INT(3), Pgender VARCHAR(255), Paddress VARCHAR(255), Pbirthday DATE, Pcellphone_number VARCHAR(255), Ptelephone_number VARCHAR(255),
Pemail VARCHAR(255))
BEGIN
	INSERT INTO ceh_lab_inv_db.users(profile_picture, first_name, middle_name, last_name, age, gender, address, birthday, cellphone_number,
    telephone_number, email)
    VALUES(Pprofile_picture, Pfirst_name, Pmiddle_name, Plast_name, Page, Pgender, Paddress, Pbirthday, Pcellphone_number, Ptelephone_number,
    Pemail);
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `user_add_1`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `user_add_1` ()
BEGIN
	SELECT * FROM ceh_lab_inv_db.users ORDER BY id DESC LIMIT 1;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `user_add_2`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `user_add_2` (Puser_id INT, Pusername VARCHAR(255), Ppassword VARBINARY(255), Prole VARCHAR(255))
BEGIN
	INSERT INTO ceh_lab_inv_db.accounts(user_id, username, password, role)
    VALUES(Puser_id, Pusername, AES_ENCRYPT(Ppassword, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'), Prole);
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `user_update`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `user_update` (Pid INT, Pprofile_picture BLOB, Pusername VARCHAR(255), Ppassword VARBINARY(255), Pfirst_name VARCHAR(255), 
Pmiddle_name VARCHAR(255), Plast_name VARCHAR(255), Page INT(3), Pgender VARCHAR(255), Paddress VARCHAR(255), Pbirthday DATE, Pcellphone_number VARCHAR(255),
Ptelephone_number VARCHAR(255), Pemail VARCHAR(255), Prole VARCHAR(255))
BEGIN
	UPDATE ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id SET username = Pusername,
    password = AES_ENCRYPT(Ppassword, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'), profile_picture = Pprofile_picture, first_name = Pfirst_name,
    middle_name = Pmiddle_name, last_name = Plast_name, age = Page, gender = Pgender, address = Paddress, birthday = Pbirthday, cellphone_number = Pcellphone_number,
    telephone_number = Ptelephone_number, email = Pemail, role = Prole, ceh_lab_inv_db.users.updated_at = CURRENT_TIMESTAMP, ceh_lab_inv_db.accounts.updated_at = CURRENT_TIMESTAMP
    WHERE ceh_lab_inv_db.users.id = Pid;
END$$

DELIMITER ;

-- End of User

-- Start of Login

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `login`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `login` (Pusername VARCHAR(255), Ppassword VARBINARY(255))
BEGIN
	SELECT ceh_lab_inv_db.users.id, profile_picture, first_name, middle_name, last_name, age, gender, address, birthday, cellphone_number, telephone_number,
    email, username, CAST(AES_DECRYPT(password, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), role FROM ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = 
    ceh_lab_inv_db.accounts.id WHERE username = Pusername AND CAST(AES_DECRYPT(password, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR) = Ppassword;

    UPDATE ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id SET is_loggedIn = 1
    WHERE username = Pusername AND CAST(AES_DECRYPT(password, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR) = Ppassword AND is_deleted = 0;
END$$

DELIMITER ;

-- End of Login

-- Start of Logout

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `logout`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `logout` (Pid INT)
BEGIN
	UPDATE ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id SET is_loggedIn = 0
    WHERE ceh_lab_inv_db.users.id = Pid;
END$$

DELIMITER ;

-- End of Logout

-- Start of Duplicate

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `duplicate_username`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `duplicate_username` (Pusername VARCHAR(255))
BEGIN
	SELECT * FROM ceh_lab_inv_db.accounts WHERE username = Pusername AND is_deleted = 0;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `duplicate_username_proceed`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `duplicate_username_proceed` (Pid INT, Pusername VARCHAR(255))
BEGIN
	SELECT * FROM ceh_lab_inv_db.accounts WHERE id = Pid AND username = Pusername;
END$$

DELIMITER ;

-- End of Duplicate

-- Start of Supply

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `supply_load`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `supply_load` ()
BEGIN
	SELECT id, item, brand, supplier, CONCAT(FORMAT(quantity, 0), ' ', unit_of_quantity), CONCAT(FORMAT(qty, 0), ' ', unit_of_qty), CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)), CONCAT(FORMAT(exp_rgt_quantity, 0), ' ', exp_rgt_unit),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)), DATE_FORMAT(expiration_date, '%m/%d/%y'), CONCAT(DATEDIFF(expiration_date, NOW()), ' DAYS LEFT'),
    DATE_FORMAT(created_at, '%m/%d/%y'), DATE_FORMAT(updated_at, '%m/%d/%y') FROM ceh_lab_inv_db.supplies WHERE is_deleted = 0 ORDER BY item ASC;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `supply_load_by_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `supply_load_by_date` (Pfrom DATE, Pto DATE)
BEGIN
	SELECT id, item, brand, supplier, CONCAT(FORMAT(quantity, 0), ' ', unit_of_quantity), CONCAT(FORMAT(qty, 0), ' ', unit_of_qty), CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)), CONCAT(FORMAT(exp_rgt_quantity, 0), ' ', exp_rgt_unit),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)), DATE_FORMAT(expiration_date, '%m/%d/%y'), CONCAT(DATEDIFF(expiration_date, NOW()), ' DAYS LEFT'),
    DATE_FORMAT(created_at, '%m/%d/%y'), DATE_FORMAT(updated_at, '%m/%d/%y') FROM ceh_lab_inv_db.supplies WHERE created_at BETWEEN Pfrom AND Pto AND is_deleted = 0 ORDER BY item ASC LIMIT 500;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `supply_get`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `supply_get` (Pid INT)
BEGIN
	SELECT id, item, brand, supplier, quantity, unit_of_quantity, qty, unit_of_qty, CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
    CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), exp_rgt_quantity, exp_rgt_unit,
    CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), expiration_date FROM ceh_lab_inv_db.supplies WHERE id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `supply_add`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `supply_add` (Pitem VARCHAR(255), Pbrand VARCHAR(255), Psupplier VARCHAR(255), Pquantity INT, Punit_of_quantity VARCHAR(255), Pqty INT, Punit_of_qty VARCHAR(255), Punit_cost VARBINARY(255),
Ptotal_cost VARBINARY(255), Pexpiration_date DATE)
BEGIN
	INSERT INTO ceh_lab_inv_db.supplies(item, brand, supplier, quantity, unit_of_quantity, qty, unit_of_qty, unit_cost, total_cost, expiration_date)
    VALUES(Pitem, Pbrand, Psupplier, Pquantity, Punit_of_quantity, Pqty, Punit_of_qty, AES_ENCRYPT(Punit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'),
    AES_ENCRYPT(Ptotal_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'), Pexpiration_date);
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `supply_update`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `supply_update` (Pid INT, Pitem VARCHAR(255), Pbrand VARCHAR(255), Psupplier VARCHAR(255), Pquantity INT, Punit_of_quantity VARCHAR(255),
Pqty INT, Punit_of_qty VARCHAR(255), Punit_cost VARBINARY(255), Ptotal_cost VARBINARY(255), Pexp_rgt_quantity INT, Pexp_rgt_unit VARCHAR(255),
Pexp_rgt_cost VARBINARY(255), Pexpiration_date DATE)
BEGIN
	UPDATE ceh_lab_inv_db.supplies SET item = Pitem, brand = Pbrand, supplier = Psupplier, quantity = Pquantity, unit_of_quantity = Punit_of_quantity, qty = Pqty, unit_of_qty = Punit_of_qty,
    unit_cost = AES_ENCRYPT(Punit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'), total_cost = AES_ENCRYPT(Ptotal_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'),
    exp_rgt_quantity = Pexp_rgt_quantity, exp_rgt_unit = Pexp_rgt_unit, exp_rgt_cost = AES_ENCRYPT(Pexp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'),
    expiration_date = Pexpiration_date, updated_at = CURRENT_TIMESTAMP WHERE id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `supply_delete`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `supply_delete` (Pid INT)
BEGIN
	UPDATE ceh_lab_inv_db.supplies SET is_deleted = 1, updated_at = CURRENT_TIMESTAMP WHERE id = Pid;
END$$

DELIMITER ;

-- End of Supply

-- Start of Report

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `report_load_supplies`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `report_load_supplies` ()
BEGIN
	SELECT item AS 'item', brand AS 'brand', supplier AS 'supplier', CONCAT(FORMAT(quantity, 0), ' ', unit_of_quantity) AS 'quantity', CONCAT(FORMAT(qty, 0), ' ', unit_of_qty) AS 'qty',
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)) AS 'unit_cost',
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)) AS 'total_cost',
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)) AS 'exp_rgt_cost', DATE_FORMAT(expiration_date, '%m/%d/%y') AS 'expiration_date'
    FROM ceh_lab_inv_db.supplies WHERE is_deleted = 0 ORDER BY item ASC;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `report_load_supplies_by_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `report_load_supplies_by_date` (Pfrom DATE, Pto DATE)
BEGIN
	SELECT item AS 'item', brand AS 'brand', supplier AS 'supplier', CONCAT(FORMAT(quantity, 0), ' ', unit_of_quantity) AS 'quantity', CONCAT(FORMAT(qty, 0), ' ', unit_of_qty) AS 'qty',
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)) AS 'unit_cost',
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)) AS 'total_cost',
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)) AS 'exp_rgt_cost', DATE_FORMAT(expiration_date, '%m/%d/%y') AS 'expiration_date'
    FROM ceh_lab_inv_db.supplies WHERE created_at BETWEEN Pfrom AND Pto AND is_deleted = 0 ORDER BY item ASC;
END$$

DELIMITER ;

-- End of Report

-- Start of Account

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `account_load`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `account_load` ()
BEGIN
	SELECT ceh_lab_inv_db.users.id, first_name, middle_name, last_name, age, gender, role, DATE_FORMAT(ceh_lab_inv_db.users.created_at, '%m/%d/%y'), DATE_FORMAT(ceh_lab_inv_db.users.updated_at, '%m/%d/%y')
    FROM ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id WHERE is_deleted = 0 ORDER BY first_name ASC;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `account_get`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `account_get` (Pid INT)
BEGIN
	SELECT ceh_lab_inv_db.users.id, profile_picture, first_name, middle_name, last_name, age, gender, address, birthday, cellphone_number, telephone_number,
    email, username, CAST(AES_DECRYPT(password, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), role FROM ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = 
    ceh_lab_inv_db.accounts.id WHERE ceh_lab_inv_db.users.id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `account_update`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `account_update` (Pid INT, Pusername VARCHAR(255), Ppassword VARBINARY(255), Pfirst_name VARCHAR(255), 
Pmiddle_name VARCHAR(255), Plast_name VARCHAR(255), Page INT(3), Pgender VARCHAR(255), Paddress VARCHAR(255), Pbirthday DATE, Pcellphone_number VARCHAR(255),
Ptelephone_number VARCHAR(255), Pemail VARCHAR(255), Prole VARCHAR(255))
BEGIN
	UPDATE ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id SET username = Pusername,
    password = AES_ENCRYPT(Ppassword, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'), first_name = Pfirst_name,
    middle_name = Pmiddle_name, last_name = Plast_name, age = Page, gender = Pgender, address = Paddress, birthday = Pbirthday, cellphone_number = Pcellphone_number,
    telephone_number = Ptelephone_number, email = Pemail, role = Prole, ceh_lab_inv_db.users.updated_at = CURRENT_TIMESTAMP, ceh_lab_inv_db.accounts.updated_at = CURRENT_TIMESTAMP
    WHERE ceh_lab_inv_db.users.id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `account_delete`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `account_delete` (Pid INT)
BEGIN
	UPDATE ceh_lab_inv_db.users SET is_deleted = 1 WHERE id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `account_delete_1`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `account_delete_1` (Puser_id INT)
BEGIN
	UPDATE ceh_lab_inv_db.accounts SET is_deleted = 1 WHERE user_id = Puser_id;
END$$

DELIMITER ;

-- End of Account

-- Start of Count

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `count_supplies_by_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `count_supplies_by_date` (Pfrom DATE, Pto DATE)
BEGIN
	SELECT COUNT(*) FROM ceh_lab_inv_db.supplies WHERE created_at BETWEEN Pfrom AND Pto AND is_deleted = 0;
END$$

DELIMITER ;

-- End of Count