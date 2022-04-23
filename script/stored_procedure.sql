-- Start of User

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
END$$

DELIMITER ;

-- End of Login

-- Start of Duplicate

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `duplicate_username`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `duplicate_username` (Pusername VARCHAR(255))
BEGIN
	SELECT * FROM ceh_lab_inv_db.accounts WHERE username = Pusername;
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
    DATE_FORMAT(date_created, '%m/%d/%y') FROM ceh_lab_inv_db.supplies;
END$$

DELIMITER ;

--

-- USE `ceh_lab_inv_db`;
-- DROP procedure IF EXISTS `supply_load_by_date`;

-- DELIMITER $$
-- USE `ceh_lab_inv_db`$$
-- CREATE PROCEDURE `supply_load_by_date` (Pfrom DATE, Pto DATE)
-- BEGIN
-- 	SELECT id, DATE_FORMAT(expiration_date, '%m/%d/%y'), CONCAT(DATEDIFF(expiration_date, NOW()), ' ', 'DAYS LEFT'), CONCAT(quantity, ' ', unit_of_quantity), item, brand, CONCAT(qty, ' ', unit_of_qty), supplier,
--     CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
--     CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
--     CONCAT(exp_rgt_quantity, ' ', exp_rgt_unit), CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
--     CAST(AES_DECRYPT(exp_rgt_total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
--     DATE_FORMAT(date_created, '%m/%d/%y') FROM ceh_lab_inv_db.supplies WHERE DATE(date_created) = DATE(Pfrom) <= DATE(Pto) ORDER BY item ASC LIMIT 500;
-- END$$

-- DELIMITER ;

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
	UPDATE ceh_lab_inv_db.supplies SET item = Pitem, brand = Pbrand, supplier = Psupplier, quantity = Pquantity, unit_of_quantity = Punit_of_quantity, qty = Pqty, unit_of_qty = Punit_of_quantity,
    unit_cost = AES_ENCRYPT(Punit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'), total_cost = AES_ENCRYPT(Ptotal_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'),
    exp_rgt_quantity = Pexp_rgt_quantity, exp_rgt_unit = Pexp_rgt_unit, exp_rgt_cost = AES_ENCRYPT(Pexp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'),
    expiration_date = Pexpiration_date WHERE id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `supply_delete`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `supply_delete` (Pid INT)
BEGIN
	DELETE FROM ceh_lab_inv_db.supplies WHERE id = Pid;
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
	SELECT id, item, brand, supplier, CONCAT(FORMAT(quantity, 0), ' ', unit_of_quantity), CONCAT(FORMAT(qty, 0), ' ', unit_of_qty), CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)), CONCAT(FORMAT(exp_rgt_quantity, 0), ' ', exp_rgt_unit),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), 2)), DATE_FORMAT(expiration_date, '%m/%d/%y') FROM ceh_lab_inv_db.supplies;
END$$

DELIMITER ;

-- End of Report