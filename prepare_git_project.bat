@echo off
echo.
echo 🔄 Nettoyage des dossiers bin/ et obj/...
for /r %%i in (bin,obj) do (
    if exist "%%i" (
        echo Supprime : %%i
        rmdir /s /q "%%i"
    )
)

echo.
echo 📦 Copie du fichier .gitignore MAUI personnalisé...
copy "C:\Users\metma\Desktop\ok\1OKIOKI\ModelsGit\.gitignore" .gitignore

echo.
echo ✅ Initialisation du dépôt Git...
git init
git add .
git commit -m "Initial commit avec .gitignore MAUI"

echo.
echo 🚀 Projet prêt ! Tu peux maintenant faire un git remote add origin...
pause
