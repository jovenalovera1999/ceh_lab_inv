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
    DATE_FORMAT(date_created, '%W, %d %M %Y') FROM ceh_lab_inv_db.supplies;
END$$

DELIMITER ;

-- End of IncomingSupply