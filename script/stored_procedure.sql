--
-- // Login
--
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `login`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `login` (p_username VARCHAR(255), p_password VARBINARY(255))
BEGIN
	SELECT ceh_lab_inv_db.users.id, profile_picture, first_name, middle_name, last_name, age, gender, address, birthday, cellphone_number, telephone_number, email, username,
    CAST(AES_DECRYPT(password, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), user_type FROM ceh_lab_inv_db.users
    INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id WHERE username = p_username AND
    CAST(AES_DECRYPT(password, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR) = p_password;

    UPDATE ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id SET is_loggedIn = 1 WHERE username = p_username AND
    CAST(AES_DECRYPT(password, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR) = p_password;
END$$

DELIMITER ;
-- //
-- // Logout
-- //
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `logout`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `logout` (p_id INT)
BEGIN
	UPDATE ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id SET is_loggedIn = 0 WHERE ceh_lab_inv_db.users.id = p_id;
END$$

DELIMITER ;
-- //
-- // Sign Up
-- //
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `sign_up_one`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `sign_up_one` (p_profile_picture BLOB, p_first_name VARCHAR(255), p_middle_name VARCHAR(255), p_last_name VARCHAR(255), p_age INT(3),
p_gender VARCHAR(255), p_address VARCHAR(255), p_birthday DATE, p_cellphone_number VARCHAR(255), p_telephone_number VARCHAR(255), p_email VARCHAR(255))
BEGIN
	INSERT INTO ceh_lab_inv_db.users(profile_picture, first_name, middle_name, last_name, age, gender, address, birthday, cellphone_number, telephone_number, email)
    VALUES(p_profile_picture, p_first_name, p_middle_name, p_last_name, p_age, p_gender, p_address, p_birthday, p_cellphone_number, p_telephone_number, p_email);
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `sign_up_two`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `sign_up_two` ()
BEGIN
	SELECT * FROM ceh_lab_inv_db.users ORDER BY id DESC;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `sign_up_three`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `sign_up_three` (p_user_id INT, p_username VARCHAR(255), p_password VARBINARY(255), p_user_type VARCHAR(255))
BEGIN
	INSERT INTO ceh_lab_inv_db.accounts(user_id, username, password, user_type)
    VALUES(p_user_id, p_username, AES_ENCRYPT(p_password, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'), p_user_type);
END$$

DELIMITER ;
-- //
-- // Duplicate
-- //
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `duplicate_username`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `duplicate_username` (p_username VARCHAR(255))
BEGIN
	SELECT username FROM ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id WHERE username = p_username AND is_deleted = 0;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `duplicate_username_proceed`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `duplicate_username_proceed` (p_id INT, p_username VARCHAR(255))
BEGIN
	SELECT ceh_lab_inv_db.users.id, username FROM ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id WHERE ceh_lab_inv_db.users.id = p_id AND username = p_username;
END$$

DELIMITER ;
-- //
-- // User
-- //
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `get_user`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `get_user` (p_id INT)
BEGIN
	SELECT ceh_lab_inv_db.users.id, profile_picture, first_name, middle_name, last_name, age, gender, address, birthday, cellphone_number, telephone_number, email, username,
    CAST(AES_DECRYPT(password, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), user_type FROM ceh_lab_inv_db.users
    INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id WHERE ceh_lab_inv_db.users.id = p_id;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `update_user`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `update_user` (p_id INT, p_profile_picture BLOB, p_first_name VARCHAR(255), p_middle_name VARCHAR(255), p_last_name VARCHAR(255), p_age INT(3),
p_gender VARCHAR(255), p_address VARCHAR(255), p_birthday DATE, p_cellphone_number VARCHAR(255), p_telephone_number VARCHAR(255), p_email VARCHAR(255),
p_username VARCHAR(255), p_password VARBINARY(255))
BEGIN
	UPDATE ceh_lab_inv_db.users INNER JOIN ceh_lab_inv_db.accounts ON ceh_lab_inv_db.users.id = ceh_lab_inv_db.accounts.id SET profile_picture = p_profile_picture, first_name = p_first_name,
    middle_name = p_middle_name, last_name = p_last_name, age = p_age, gender = p_gender, address = p_address, birthday = p_birthday, cellphone_number = p_cellphone_number,
    telephone_number = p_telephone_number, email = p_email, username = p_username, password = AES_ENCRYPT(p_password, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'),
    ceh_lab_inv_db.users.updated_at = CURRENT_TIMESTAMP, ceh_lab_inv_db.accounts.updated_at = CURRENT_TIMESTAMP WHERE ceh_lab_inv_db.users.id = p_id;
END$$

DELIMITER ;
-- //
-- // Supply
-- //
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `get_supply`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `get_supply` (p_id INT)
BEGIN
	SELECT id, item, brand, supplier, quantity, unit_of_quantity, qty, unit_of_qty, CAST(AES_DECRYPT(unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 
    CAST(AES_DECRYPT(total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), exp_rgt_quantity, exp_rgt_unit, CAST(AES_DECRYPT(exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), expiration_date
    FROM ceh_lab_inv_db.supplies WHERE id = p_id;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `load_supplies`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `load_supplies` ()
BEGIN
	SELECT id, item, brand, supplier, CONCAT(quantity, ' ', unit_of_quantity), CONCAT(qty, ' ', unit_of_qty), CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), 
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), CONCAT(exp_rgt_quantity, ' ', exp_rgt_unit),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), DATE_FORMAT(expiration_date, '%m/%d/%y'), CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left'),
    DATE_FORMAT(created_at, '%m/%d/%y'), DATE_FORMAT(updated_at, '%m/%d/%y') FROM ceh_lab_inv_db.supplies WHERE is_deleted = 0 ORDER BY item ASC;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `load_supplies_by_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `load_supplies_by_date` (p_keyword VARCHAR(255))
BEGIN
	SELECT id, item, brand, supplier, CONCAT(quantity, ' ', unit_of_quantity), CONCAT(qty, ' ', unit_of_qty), CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), 
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), CONCAT(exp_rgt_quantity, ' ', exp_rgt_unit),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), DATE_FORMAT(expiration_date, '%m/%d/%y'), CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left'),
    DATE_FORMAT(created_at, '%m/%d/%y'), DATE_FORMAT(updated_at, '%m/%d/%y') FROM ceh_lab_inv_db.supplies WHERE item LIKE p_keyword AND is_deleted = 0 OR brand LIKE p_keyword AND is_deleted = 0
    OR supplier LIKE p_keyword AND is_deleted = 0 ORDER BY item ASC;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `load_trash`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `load_trash` ()
BEGIN
	SELECT id, item, brand, supplier, CONCAT(quantity, ' ', unit_of_quantity), CONCAT(qty, ' ', unit_of_qty), CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), 
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), CONCAT(exp_rgt_quantity, ' ', exp_rgt_unit),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)), DATE_FORMAT(expiration_date, '%m/%d/%y'), CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left'),
    DATE_FORMAT(created_at, '%m/%d/%y'), DATE_FORMAT(updated_at, '%m/%d/%y') FROM ceh_lab_inv_db.supplies WHERE is_deleted = 1 ORDER BY item ASC;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `add_supply_with_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `add_supply_with_date` (p_item VARCHAR(255), p_brand VARCHAR(255), p_supplier VARCHAR(255), p_quantity INT, p_unit_of_quantity VARCHAR(255), p_qty INT, p_unit_of_qty VARCHAR(255),
p_unit_cost VARBINARY(255), p_total_cost VARBINARY(255), p_expiration_date DATE)
BEGIN
	INSERT INTO ceh_lab_inv_db.supplies(item, brand, supplier, quantity, unit_of_quantity, qty, unit_of_qty, unit_cost, total_cost, expiration_date)
    VALUES(p_item, p_brand, p_supplier, p_quantity, p_unit_of_quantity, p_qty, p_unit_of_qty, AES_ENCRYPT(p_unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'),
    AES_ENCRYPT(p_total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'), p_expiration_date);
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `add_supply_without_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `add_supply_without_date` (p_item VARCHAR(255), p_brand VARCHAR(255), p_supplier VARCHAR(255), p_quantity INT, p_unit_of_quantity VARCHAR(255), p_qty INT, p_unit_of_qty VARCHAR(255),
p_unit_cost VARBINARY(255), p_total_cost VARBINARY(255))
BEGIN
	INSERT INTO ceh_lab_inv_db.supplies(item, brand, supplier, quantity, unit_of_quantity, qty, unit_of_qty, unit_cost, total_cost)
    VALUES(p_item, p_brand, p_supplier, p_quantity, p_unit_of_quantity, p_qty, p_unit_of_qty, AES_ENCRYPT(p_unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'),
    AES_ENCRYPT(p_total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'));
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `update_supply_with_expiration_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `update_supply_with_expiration_date` (p_id INT, p_item VARCHAR(255), p_brand VARCHAR(255), p_supplier VARCHAR(255), p_quantity INT, p_unit_of_quantity VARCHAR(255), p_qty INT,
p_unit_of_qty VARCHAR(255), p_unit_cost VARBINARY(255), p_total_cost VARBINARY(255), p_expiration_date DATE)
BEGIN
    UPDATE ceh_lab_inv_db.supplies SET item = p_item, brand = p_brand, supplier = p_supplier, quantity = p_quantity, unit_of_quantity = p_unit_of_quantity, qty = p_qty, unit_of_qty = p_unit_of_qty,
    unit_cost = AES_ENCRYPT(p_unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'), total_cost = AES_ENCRYPT(p_total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'), expiration_date = p_expiration_date,
    updated_at = CURRENT_TIMESTAMP WHERE id = p_id;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `update_supply_without_expiration_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `update_supply_without_expiration_date` (p_id INT, p_item VARCHAR(255), p_brand VARCHAR(255), p_supplier VARCHAR(255), p_quantity INT, p_unit_of_quantity VARCHAR(255), p_qty INT,
p_unit_of_qty VARCHAR(255), p_unit_cost VARBINARY(255), p_total_cost VARBINARY(255))
BEGIN
	UPDATE ceh_lab_inv_db.supplies SET item = p_item, brand = p_brand, supplier = p_supplier, quantity = p_quantity, unit_of_quantity = p_unit_of_quantity, qty = p_qty, unit_of_qty = p_unit_of_qty,
    unit_cost = AES_ENCRYPT(p_unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'), total_cost = AES_ENCRYPT(p_total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'), updated_at = CURRENT_TIMESTAMP WHERE id = p_id;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `update_supply_rgt`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `update_supply_rgt` (p_id INT, p_exp_rgt_quantity INT, p_exp_rgt_unit VARCHAR(255), p_exp_rgt_cost VARBINARY(255))
BEGIN
	UPDATE ceh_lab_inv_db.supplies SET exp_rgt_quantity = p_exp_rgt_quantity, exp_rgt_unit = p_exp_rgt_unit, exp_rgt_cost = AES_ENCRYPT(p_exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry'),
    updated_at = CURRENT_TIMESTAMP WHERE id = p_id;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `delete_supply`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `delete_supply` (p_id INT)
BEGIN
	UPDATE ceh_lab_inv_db.supplies SET is_deleted = 1 WHERE id = p_id;
END$$

DELIMITER ;
-- //
-- // Count
-- //
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `count_supplies`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `count_supplies` ()
BEGIN
	SELECT COUNT(*) FROM ceh_lab_inv_db.supplies WHERE is_deleted = 0;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `count_supplies_by_search`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `count_supplies_by_search` (p_keyword VARCHAR(255))
BEGIN
	SELECT COUNT(*) FROM ceh_lab_inv_db.supplies WHERE item LIKE p_keyword AND is_deleted = 0 OR brand LIKE p_keyword AND is_deleted = 0 OR supplier LIKE p_keyword AND is_deleted = 0 ORDER BY item ASC;
END$$

DELIMITER ;

USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `count_trash`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `count_trash` ()
BEGIN
	SELECT COUNT(*) FROM ceh_lab_inv_db.supplies WHERE is_deleted = 1;
END$$

DELIMITER ;
-- //
-- // Print
-- //
USE `ceh_lab_inv_db`;
DROP procedure IF EXISTS `load_print_supplies_by_date`;

DELIMITER $$
USE `ceh_lab_inv_db`$$
CREATE PROCEDURE `load_print_supplies_by_date` (p_from DATE, p_to DATE)
BEGIN
	SELECT item AS 'item', brand AS 'brand', supplier AS 'supplier', CONCAT(quantity, ' ', unit_of_quantity) AS 'quantity', CONCAT(qty, ' ', unit_of_qty) AS 'qty',
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(unit_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)) AS 'unit_cost', 
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(total_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)) AS 'total_cost', CONCAT(exp_rgt_quantity, ' ', exp_rgt_unit),
    CONCAT('₱', FORMAT(CAST(AES_DECRYPT(exp_rgt_cost, 'eMm4nu3lh0sp1t4Ll4b0r4T0Ry') AS CHAR), 2)) AS 'exp_rgt_cost',
    DATE_FORMAT(expiration_date, '%m/%d/%y') AS 'expiration_date' FROM ceh_lab_inv_db.supplies WHERE created_at BETWEEN p_from AND p_to AND is_deleted = 0 ORDER BY item ASC;
END$$

DELIMITER ;