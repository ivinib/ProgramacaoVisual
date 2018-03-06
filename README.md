# ProgramacaoVisual

Códigos da disciplina de programação visual

git clone https://github.com/ivinib/ProgramacaoVisual

mkdir source
cd source

mkdir ProgramacaoVisual
cd Programacao visual

dotnet new sln

mkdir WebMvc
cd mvc

dotnet new WebMvc

cd ..

dotnet sln ProgramacaoVisual.sln add WebMvc/WebMvc.csproj

git add *

git commit -m "Initial Commit"

git config --global  user.e-mail-"vi_ni_b@hotmail.com"

git config --global  user.name = "Vinicius Augusto Basso"

git push origin master