DROP TABLE IF EXISTS [Users];
DROP TABLE IF EXISTS [Tasks];

CREATE TABLE [Users] (
Id varchar(13) NOT NULL PRIMARY KEY,
Password varchar(255) NOT NULL
);
CREATE TABLE [Tasks] (
Id_Task int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Id varchar(13) NOT NULL,
Date_month varchar(10) NOT NULL,
Text nvarchar(255) NOT NULL
);

INSERT INTO [Users] VALUES ('admin', 'admin');
INSERT INTO [Users] VALUES ('user', 'user');

INSERT INTO [Tasks] (Id, Date_month, Text) VALUES ('admin', '05/06/2023', N'Яблоко');
INSERT INTO [Tasks] (Id, Date_month, Text) VALUES ('admin', '03/06/2023', N'Банан');
INSERT INTO [Tasks] (Id, Date_month, Text) VALUES ('admin', '02/06/2023', N'Груша');
INSERT INTO [Tasks] (Id, Date_month, Text) VALUES ('admin', '01/06/2023', N'Персик');

INSERT INTO [Tasks] (Id, Date_month, Text) VALUES ('user', '05/06/2023', N'Апельсин');
INSERT INTO [Tasks] (Id, Date_month, Text) VALUES ('user', '02/06/2023', N'Ананас');
INSERT INTO [Tasks] (Id, Date_month, Text) VALUES ('user', '01/06/2023', N'Киви');

SELECT * FROM [Users];
SELECT * FROM [Tasks];
