dotnet publish -p:PublishProfile=FolderProfile
robocopy 1206/bin/Release/net6.0/publish BUILD-win-x64 /E
copy LICENSE BUILD-win-x64/LICENSE /Y