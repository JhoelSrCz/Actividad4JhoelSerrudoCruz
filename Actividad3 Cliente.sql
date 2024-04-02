CREATE TABLE CLIENTE (
IDCLIENTE INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
APELLIDO NVARCHAR (50) NOT NULL,
CORREOELECTRONICO NVARCHAR (50) NOT NULL,
TELEFONO NVARCHAR (30) NOT NULL,
DIRECCION NVARCHAR (50) NOT NULL,
PRIMARY KEY (IDCLIENTE),
);

CREATE TABLE PEDIDO (
IDPEDIDO INT IDENTITY (1,1) NOT NULL,
IDCLIENTE INT NOT NULL,
FECHA DATETIME NOT NULL,
TOTAL MONEY NOT NULL,
ESTADO NVARCHAR (20) NOT NULL,
PRIMARY KEY (IDPEDIDO),
FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE),
);

select * from CLIENTE

INSERT INTO CLIENTE VALUES('Francisco', 'Gomez', 'pancho23@gmail.com', '7882443154', 'B. Ovilos');
insert into CLIENTE values('Pedro' ,'Fernandez','pedro@gmail.com','5744158','B. Ovilos');
insert into CLIENTE values('Adri�n' ,'P�rez' ,'adrian@gmail.com' ,'1234567' ,'B. Ovilos');
insert into CLIENTE values('Bel�n','Gonz�lez' ,'belen@gmail.com' ,'87654321' ,'B. Ovilos');
insert into CLIENTE values('Ana' ,'Rodr�guez' ,'ana@gmail.com' ,'2345678' ,'B. Ovilos');
insert into CLIENTE values('Bruno' ,'L�pez' ,'bruno@gmail.com' ,'76543210' ,'B. Ovilos');
insert into CLIENTE values('Carla' ,'Garc�a' ,'carla@gmail.com' ,'3456789' ,'B. Ovilos');
insert into CLIENTE values('Diego' ,'S�nchez' ,'diego@gmail.com' ,'65432109' ,'B. Ovilos');
insert into CLIENTE values('Elena' ,'Mart�nez' ,'elena@gmail.com' ,'4567890' ,'B. Ovilos');


INSERT INTO PEDIDO (IDCLIENTE, FECHA, TOTAL, ESTADO)
VALUES (1, '2024-04-02 10:00:00', 75.00, 'EN PROCESO');
INSERT INTO PEDIDO (IDCLIENTE, FECHA, TOTAL, ESTADO)
VALUES (1, '2024-04-02 11:15:00', 30.00, 'ENTREGADO');
INSERT INTO PEDIDO (IDCLIENTE, FECHA, TOTAL, ESTADO)
VALUES (2, '2024-04-02 12:30:00', 100.00, 'PENDIENTE');
INSERT INTO PEDIDO (IDCLIENTE, FECHA, TOTAL, ESTADO)
VALUES (2, '2024-04-02 13:45:00', 45.00, 'ENVIADO');
INSERT INTO PEDIDO (IDCLIENTE, FECHA, TOTAL, ESTADO)
VALUES (3, '2024-04-02 14:00:00', 60.00, 'EN PROCESO');


SELECT * FROM PEDIDO