# InventorySystem
# 🧊 Frozen Inventory System

Un système de gestion d'inventaire pour entrepôts frigorifiques développé en ASP.NET MVC.

## 📋 Description

Frozen Inventory System est une application web complète de gestion d'inventaire spécialement conçue pour les entrepôts frigorifiques. Elle permet de gérer efficacement les stocks, les mouvements de marchandises, les clients, les factures et les rapports dans un environnement de froid.

## ✨ Fonctionnalités

### 🔐 Authentification et Sécurité
- Système d'authentification sécurisé avec BCrypt
- Gestion des utilisateurs et des rôles
- Protection des routes avec autorisation

### 📦 Gestion des Produits
- Catalogue complet des produits
- Suivi des stocks en temps réel
- Gestion des catégories et des unités

### 🏢 Gestion des Clients
- Base de données clients complète
- Historique des commandes
- Informations de contact détaillées

### ❄️ Gestion des Chambres Froides
- Suivi des températures
- Gestion des zones de stockage
- Optimisation de l'espace de stockage

### 📋 Mouvements de Stock
- **Bons d'entrée** : Réception des marchandises
- **Bons de sortie** : Expédition des commandes
- Traçabilité complète des mouvements

### 💰 Comptabilité
- Gestion des factures
- Suivi des paiements
- Rapports financiers

### 📊 Rapports et Analytics
- Rapports de stock
- Analyses de performance
- Statistiques de vente

### 🚚 Gestion des Frégons
- Suivi des véhicules frigorifiques
- Planification des livraisons
- Maintenance des équipements

## 🛠️ Technologies Utilisées

### Backend
- **ASP.NET MVC 5.2.9** - Framework web
- **.NET Framework 4.7.2** - Plateforme de développement
- **Entity Framework 6.4.4** - ORM pour la base de données
- **SQL Server** - Base de données relationnelle
- **BCrypt.Net-Next 4.0.3** - Hachage sécurisé des mots de passe

### Frontend
- **Bootstrap 3.4.1** - Framework CSS responsive
- **jQuery 3.7.1** - Bibliothèque JavaScript
- **jQuery Validation 1.17.0** - Validation côté client
- **Modernizr 2.8.3** - Détection des fonctionnalités navigateur

### Outils de Développement
- **Visual Studio 2019** - IDE principal
- **NuGet** - Gestionnaire de packages
- **PagedList** - Pagination des données

## 📦 Prérequis

### Système
- Windows 10/11 ou Windows Server 2016+
- .NET Framework 4.7.2 ou supérieur
- SQL Server 2016 ou supérieur
- IIS (pour le déploiement en production)

### Développement
- Visual Studio 2019
- SQL Server Management Studio (recommandé)
- Git pour le contrôle de version

## 🚀 Installation

### 1. Cloner le Repository
```bash
git clone https://github.com/votre-username/FrozenInventorySystem.git
cd FrozenInventorySystem
```

### 2. Configuration de la Base de Données
1. Ouvrez SQL Server Management Studio
2. Créez une nouvelle base de données nommée `FrozenInventoryDB`
3. Modifiez la chaîne de connexion dans `Web.config` :
```xml
<connectionStrings>
    <add name="FrozenInventoryDB" 
         connectionString="Data Source=VOTRE_SERVEUR;Initial Catalog=FrozenInventoryDB;Integrated Security=True;MultipleActiveResultSets=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 3. Restauration des Packages NuGet
1. Ouvrez la solution dans Visual Studio
2. Clic droit sur la solution → "Restore NuGet Packages"
3. Ou exécutez dans la Console Package Manager :
```powershell
Update-Package -reinstall
```

### 4. Migration de la Base de Données
1. Ouvrez la Console Package Manager dans Visual Studio
2. Exécutez les commandes suivantes :
```powershell
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```

### 5. Compilation et Exécution
1. Appuyez sur `F5` ou cliquez sur "Start Debugging"
2. L'application s'ouvrira dans votre navigateur par défaut

## 🖼️ Aperçu du projet

<img width="1887" height="869" alt="image" src="https://github.com/user-attachments/assets/97787398-4f61-4ee0-aec6-d22d098a2dfe" />
<img width="1915" height="903" alt="image" src="https://github.com/user-attachments/assets/96dcc105-579c-45ac-8c03-9b0e21747023" />
<img width="1919" height="905" alt="image" src="https://github.com/user-attachments/assets/d83ff9c1-7d24-4c8e-b97e-2b1a3875b91d" />
<img width="1913" height="896" alt="image" src="https://github.com/user-attachments/assets/99c66e9f-c4de-4ba5-95b0-696448c2dcbc" />
<img width="1904" height="910" alt="image" src="https://github.com/user-attachments/assets/3013e703-4b8d-4ae9-a6df-9957af1401a3" />
<img width="1909" height="900" alt="image" src="https://github.com/user-attachments/assets/a03a4563-5549-40ff-aa88-15df1cf2ebdc" />
<img width="1917" height="905" alt="image" src="https://github.com/user-attachments/assets/80187caf-e1a7-4abd-8f10-452aeb1b844d" />
<img width="1911" height="872" alt="image" src="https://github.com/user-attachments/assets/8cb425ad-04f9-4dff-a934-9283b0e72666" />
<img width="1919" height="900" alt="image" src="https://github.com/user-attachments/assets/b1b045a9-52df-4962-9fb6-469533cd6f4d" />








