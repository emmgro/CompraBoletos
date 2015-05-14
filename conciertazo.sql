CREATE DATABASE IF NOT EXISTS conciertazo;
USE conciertazo;

DROP TABLE IF EXISTS cliente;
CREATE TABLE IF NOT EXISTS cliente(
cl_id INT(3) NOT NULL auto_increment primary key,
cl_nom VARCHAR(64)
);

DROP TABLE IF EXISTS asiento;
CREATE TABLE IF NOT EXISTS asiento(
as_numero VARCHAR(4) NOT NULL primary key,
as_status VARCHAR(14),
cl_id INT(3),
FOREIGN KEY (cl_id) REFERENCES cliente (cl_id)
);

DROP TABLE IF EXISTS numero_asiento;
CREATE TABLE IF NOT EXISTS numero_asiento(
reservacion_id INT(3) NOT NULL auto_increment primary key,
cl_id int(3),
as_numero VARCHAR(4),
FOREIGN KEY (cl_id) REFERENCES cliente (cl_id),
FOREIGN KEY (as_numero) REFERENCES asiento (as_numero)
);

INSERT INTO asiento(as_numero,as_status)
VALUES ("A1","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("A2","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("A3","VENDIDO");
INSERT INTO asiento(as_numero,as_status)
VALUES ("A4","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("B1","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("B2","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("B3","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("B4","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("C1","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("C2","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("C3","SIN VENDER");
INSERT INTO asiento(as_numero,as_status)
VALUES ("C4","SIN VENDER");

