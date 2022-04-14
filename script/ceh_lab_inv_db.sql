DROP DATABASE IF EXISTS ceh_lab_inv_db;

CREATE DATABASE ceh_lab_inv_db;

CREATE TABLE ceh_lab_inv_db.users(
    id                                  INT NOT NULL AUTO_INCREMENT,
    profile_picture                     BLOB,
    first_name                          VARCHAR(255) NOT NULL,
    middle_name                         VARCHAR(255) DEFAULT NULL,
    last_name                           VARCHAR(255) NOT NULL,
    age                                 INT(3) NOT NULL,
    gender                              VARCHAR(255) NOT NULL,
    address                             VARCHAR(255) NOT NULL,
    cellphone_number                    VARCHAR(255) DEFAULT NULL,
    telephone_number                    VARCHAR(255) DEFAULT NULL,
    email                               VARCHAR(255) DEFAULT NULL,
    date_created                        TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE ceh_lab_inv_db.accounts(
    id                                  INT NOT NULL AUTO_INCREMENT,
    user_id                             INT NOT NULL,
    username                            VARCHAR(255) NOT NULL,
    password                            VARBINARY(255) NOT NULL,
    role                                VARCHAR(255) NOT NULL,
    date_created                        TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id),
    FOREIGN KEY(user_id) REFERENCES ceh_lab_inv_db.users(id)
);

CREATE TABLE ceh_lab_inv_db.supplies(
    id                                  INT NOT NULL AUTO_INCREMENT,
    arrival_date                        DATE,
    expiration_date                     DATE,
    quantity                            VARCHAR(255) NOT NULL,
    item                                VARCHAR(255) NOT NULL,
    brand                               VARCHAR(255) NOT NULL,
    qty                                 VARCHAR(255) NOT NULL,
    supplier                            VARCHAR(255) NOT NULL,
    unit_cost                           VARBINARY(255) DEFAULT NULL,    
    number_of_unit                      INT DEFAULT NULL,
    total_cost                          VARBINARY(255) DEFAULT NULL,
    exp_rgt_cost                        VARBINARY(255) DEFAULT NULL,
    status                              VARCHAR(255) NOT NULL,
    date_created                        TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);