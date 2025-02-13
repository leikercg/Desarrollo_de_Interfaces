
CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);

-- Insertar Usuario Médico

INSERT INTO Usuarios (nombre, password)
VALUES ('leiker', 'leiker');

-- Tabla Paciente
CREATE TABLE Pacientes (
    id_paciente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    calle VARCHAR(255),
    ciudad VARCHAR(100),
    cod_postal VARCHAR(10),
    telefono1 VARCHAR(20),
    telefono2 VARCHAR(20),
    telefono3 VARCHAR(20)
);

-- Tabla Informe
CREATE TABLE Informes (
    id_informe INT IDENTITY(1,1) PRIMARY KEY,
    id_paciente INT,
    fecha_creacion DATETIME DEFAULT GETDATE() NOT NULL,
    fecha_modificacion DATETIME DEFAULT GETDATE(),
    nombre_medico VARCHAR(255) DEFAULT 'Dr. Leiker' NOT NULL,
    centro_medico VARCHAR(255) DEFAULT 'Palafox' NOT NULL,
    motivo TEXT,
    recomendaciones TEXT,
    FOREIGN KEY (id_paciente) REFERENCES Pacientes(id_paciente) ON DELETE CASCADE
);

-- Tabla Medicamento
CREATE TABLE Medicamentos (
    id_medicamento INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    descuento DECIMAL(5,2) DEFAULT 0 );

-- Tabla Tratamiento
CREATE TABLE Linea_Tratamiento (
    id_tratamiento INT IDENTITY(1,1) PRIMARY KEY,
    id_informe INT,
    id_medicamento INT,
    frecuencia_horas INT DEFAULT 8 NOT NULL,  -- Valor por defecto para frecuencia_horas
    duracion_dias INT DEFAULT 7 NOT NULL,     -- Valor por defecto para duracion_dias
    FOREIGN KEY (id_informe) REFERENCES Informes(id_informe) ON DELETE CASCADE,
    FOREIGN KEY (id_medicamento) REFERENCES Medicamentos(id_medicamento) ON DELETE SET NULL
);

-- Insertar 3 pacientes
INSERT INTO Pacientes (nombre, calle, ciudad, cod_postal, telefono1, telefono2, telefono3)
VALUES
('Juan Pérez', 'Calle 123', 'Madrid', '28001', '123456789', '987654321', ''),
('María López', 'Avenida 456', 'Barcelona', '08002', '234567890', '', ''),
('Carlos Gómez', 'Plaza Mayor', 'Sevilla', '41001', '345678901', '654321987', '678912345');

-- Insertar 4 medicamentos
INSERT INTO Medicamentos (nombre, precio, descuento)
VALUES
('Paracetamol', 5.50, 0.10),
('Ibuprofeno', 7.75, 0.15),
('Omeprazol', 10.00, 0.05),
('Amoxicilina', 12.30, 0.20);

-- Insertar 1 informe para un paciente
INSERT INTO Informes (id_paciente, nombre_medico, centro_medico, motivo, recomendaciones)
VALUES
(1, 'Dr. House', 'Clínica Central', 'Dolor de cabeza recurrente', 'Tomar analgésico y reposo');

-- Insertar 1 tratamiento vinculado al informe creado
INSERT INTO Linea_Tratamiento (id_informe, id_medicamento, frecuencia_horas, duracion_dias)
VALUES
(1, 1, 8, 5);  -- Asignamos Paracetamol al primer informe
