# Cododo - Coding Challenge Desktop App
Cododo is a coding challenge desktop application which impliments LLM which learns about the user activity so it can make better challenges for the user.
&nbsp;
## Backend
Building project:
```console
dotnet build .\Backend\windows-app-coding.csproj
```
&nbsp;
Running project:
```console
dotnet run --project .\Backend\windows-app-coding.csproj
```
&nbsp;
## Frontend
Building project:
```console
dotnet build .\Frontend\windows-app-coding.csproj
```
&nbsp;
Running project:
```console
dotnet run --project .\Frontend\windows-app-coding.csproj
```
&nbsp;
Cododo impliments local LLM for:
- learning user mistakes so it can give challenge suggestions based on attempted challenges
- suggests which challenges user should do based on their past challenges
- privacy of the user ( user can opt out of giving data anytime, which would be used for making LLM better anyway)
- not sharing data to the third parties
&nbsp;
&nbsp;
Users are able to: 
- see their overview of their challenges on their profile
- see the leaderboard 
- able to discuss with each others
- are able to create challenges for the community



