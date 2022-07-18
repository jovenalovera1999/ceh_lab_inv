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
    birthday                            DATE,
    cellphone_number                    VARCHAR(255) DEFAULT NULL,
    telephone_number                    VARCHAR(255) DEFAULT NULL,
    email                               VARCHAR(255) DEFAULT NULL,
    created_at                          TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at                          TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE ceh_lab_inv_db.accounts(
    id                                  INT NOT NULL AUTO_INCREMENT,
    user_id                             INT NOT NULL,
    username                            VARCHAR(255) NOT NULL,
    password                            VARBINARY(255) NOT NULL,
    user_type                           VARCHAR(255) NOT NULL,
    is_loggedIn                         TINYINT(1) NOT NULL DEFAULT 0,
    is_deleted                          TINYINT(1) NOT NULL DEFAULT 0,
    created_at                          TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at                          TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id),
    FOREIGN KEY(user_id) REFERENCES ceh_lab_inv_db.users(id)
);

CREATE TABLE ceh_lab_inv_db.supplies(
    id                                  INT NOT NULL AUTO_INCREMENT,
    item                                VARCHAR(255) NOT NULL,
    brand                               VARCHAR(255) NOT NULL,
    supplier                            VARCHAR(255) NOT NULL,
    quantity                            INT NOT NULL,
    unit_of_quantity                    VARCHAR(255) NOT NULL,
    qty                                 INT NOT NULL,
    unit_of_qty                         VARCHAR(255) NOT NULL,
    unit_cost                           VARBINARY(255) NOT NULL,
    total_cost                          VARBINARY(255) NOT NULL,
    exp_rgt_quantity                    INT DEFAULT NULL,
    exp_rgt_unit                        VARCHAR(255) DEFAULT NULL,
    exp_rgt_cost                        VARBINARY(255) DEFAULT NULL,
    expiration_date                     DATE,
    is_deleted                          TINYINT(1) NOT NULL DEFAULT 0,
    created_at                          TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at                          TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);