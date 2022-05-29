CREATE PROCEDURE [dbo].[spBox_Create]
	@NameOfBox nvarchar(20),
	@Organization nvarchar(20),
	@GroupName nvarchar(20)
	
AS

begin
set nocount on;

	insert into dbo.BoxTB(NameOfBox, Organization, GroupName)
	values (@NameOfBox, @Organization, @GroupName);

end