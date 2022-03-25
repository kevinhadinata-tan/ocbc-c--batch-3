// productlines

CREATE TABLE productlines
(
	productLineID int primary key not null,
	textDescription varchar(200),
	htmlDescription varchar(200),
	imageProduct varchar(200)
);

// products

CREATE TABLE products
(
	productCode int primary key not null,
	productName varchar(50),
	productLineID int not null,
	productScale varchar(40),
	productVendor varchar(100),
	productDescription varchar(200),
	quantityInStock int,
	buyPrice int,
	MSRP int,
	foreign key (productLineID) references productlines(productLineID)
);

// orderdetails

CREATE TABLE orderdetails
(
	orderNumber int not null,
	productCode int not null,
	quantityOrdered int,
	priceEach int,
	orderLineNumber int,
	foreign key (productCode) references products(productCode),
	foreign key (orderNumber) references orders(orderNumber)
);

// offices

CREATE TABLE offices
(
	officeCode int primary key not null,
	city varchar(40),
	phone varchar(13),
	addressLine1 varchar(200),
	addressLine2 varchar(200),
	state varchar(100),
	country varchar(50),
	postalCode varchar(5),
	territory varchar(50)
);

// employees

create table employees
(
	employeeNumber int primary key not null,
	lastname varchar(50),
	firstname varchar(50),
	extension varchar(50),
	email varchar(50),
	officeCode int not null,
	reportsTo varchar(50),
	jobTitle varchar(60),
	foreign key (officeCode) references offices(officeCode)
);

// customers

create table customers
(
	customerNumber int primary key not null,
	customerName varchar(50),
	contactLastName varchar(50),
	contactFirstName varchar(50),
	phone varchar(13),
	addressLine1 varchar(200),
	addressLine2 varchar(200),
	city varchar(50),
	state varchar(50),
	postalCode varchar(5),
	country varchar(50),
	employeeNumber int not null,
	creditLimit int,
	foreign key (employeeNumber) references employees(employeeNumber)
);

// orders

create table orders
(
	orderNumber int primary key not null,
	orderDate date,
	requiredDate date,
	shippedDate date,
	statusOrder int,
	comments varchar(200),
	customerNumber int not null,
	foreign key (customerNumber) references customers(customerNumber)
);

// payments

CREATE TABLE payments
(
	customerNumber int not null,
	checkNumber int primary key not null,
	paymentDate date,
	amount int,
	foreign key (customerNumber) references customers(customerNumber)
);