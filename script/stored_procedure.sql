-- Start of User

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `user_add`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `user_add` (Pprofile_picture BLOB, Pfirst_name VARCHAR(255), Pmiddle_name VARCHAR(255), Plast_name VARCHAR(255),
Page INT(3), Pgender VARCHAR(255), Paddress VARCHAR(255), Pcellphone_number VARCHAR(255), Ptelephone_number VARCHAR(255),
Pemail VARCHAR(255))
BEGIN
	INSERT INTO ceh_lab_inv_db.users(profile_picture, first_name, middle_name, last_name, age, gender, address, cellphone_number,
    telephone_number, email)
    VALUES(Pprofile_picture, Pfirst_name, Pmiddle_name, Plast_name, Page, Pgender, Paddress, Pcellphone_number, Ptelephone_number,
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
	SELECT ceh_lab_inv_db.users.id, profile_picture, first_name, middle_name, last_name, age, gender, address, cellphone_number, telephone_number,
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

-- Start of IncomingSupply

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `incoming_supply_load`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `incoming_supply_load` ()
BEGIN
	SELECT id, DATE_FORMAT(expiration_date, '%W, %d %M %Y'), CONCAT(DATEDIFF(expiration_date, NOW()), ' DAYS LEFT'), quantity, item, brand, qty, supplier,
    CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), number_of_unit,
    CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
    CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR), status,
    DATE_FORMAT(arrival_date, '%W, %d %M %Y'), CONCAT(DATEDIFF(arrival_date, NOW()), ' DAYS LEFT'),
    DATE_FORMAT(date_created, '%W, %d %M %Y') FROM ceh_lab_inv_db.supplies ORDER BY item ASC LIMIT 500;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `incoming_supply_get`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `incoming_supply_get` (Pid INT)
BEGIN
	SELECT id, arrival_date, expiration_date, quantity, item, brand, qty, supplier, CAST(AES_DECRYPT(unit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
    number_of_unit, CAST(AES_DECRYPT(total_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR),
    CAST(AES_DECRYPT(exp_rgt_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') AS CHAR) FROM ceh_lab_inv_db.supplies WHERE id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `incoming_supply_add`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `incoming_supply_add` (Parrival_date DATE, Pexpiration_date DATE, Pquantity VARCHAR(255), Pitem VARCHAR(255), Pbrand VARCHAR(255),
Pqty VARCHAR(255), Psupplier VARCHAR(255), Punit_cost VARBINARY(255), Pnumber_of_unit INT, Ptotal_cost VARBINARY(255), Pstatus VARCHAR(255))
BEGIN
	INSERT INTO ceh_lab_inv_db.supplies(arrival_date, expiration_date, quantity, item, brand, qty, supplier, unit_cost, number_of_unit,
    total_cost, status)
    VALUES(Parrival_date, Pexpiration_date, Pquantity, Pitem, Pbrand, Pqty, Psupplier, AES_ENCRYPT(Punit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'),
    Pnumber_of_unit, AES_ENCRYPT(Ptotal_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'), Pstatus);
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `incoming_supply_update`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `incoming_supply_update` (Pid INT, Parrival_date DATE, Pexpiration_date DATE, Pquantity VARCHAR(255), Pitem VARCHAR(255),
Pbrand VARCHAR(255), Pqty VARCHAR(255), Psupplier VARCHAR(255), Punit_cost VARBINARY(255), Pnumber_of_unit INT, Ptotal_cost VARBINARY(255))
BEGIN
	UPDATE ceh_lab_inv_db.supplies SET arrival_date = Parrival_date, expiration_date = Pexpiration_date, quantity = Pquantity, item = Pitem,
    brand = Pbrand, qty = Pqty, supplier = Psupplier, unit_cost = AES_ENCRYPT(Punit_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test'),
    number_of_unit = Pnumber_of_unit, total_cost = AES_ENCRYPT(Ptotal_cost, 'J0V3NCUT3GW@P0P3R0J0KEL4NG+63!@#943$%^407&*?1429?!@#test') WHERE id = Pid;
END$$

DELIMITER ;

--

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `incoming_supply_delete`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `incoming_supply_delete` (Pid INT)
BEGIN
	DELETE FROM ceh_lab_inv_db.supplies WHERE id = Pid;
END$$

DELIMITER ;

-- End of IncomingSupply