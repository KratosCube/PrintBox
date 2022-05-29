CREATE PROCEDURE [dbo].[spBox_CreateData]
	@NameOfBox nvarchar(20),
	@Led nvarchar(5),
	@Door nvarchar(5)
	
AS

begin
set nocount on;

	insert into dbo.PrintBoxData(NameOfBox, Led, Door)
	values (@NameOfBox, @Led, @Door);

end