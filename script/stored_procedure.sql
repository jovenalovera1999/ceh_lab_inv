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