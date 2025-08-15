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
- Visual Studio 2019/2022
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

## 📁 Structure du Projet

```
FrozenInventorySystem/
├── Controllers/           # Contrôleurs MVC
│   ├── AccountController.cs
│   ├── HomeController.cs
│   ├── ProduitsController.cs
│   ├── ClientsController.cs
│   └── ...
├── Models/               # Modèles de données
│   ├── FrozenDbContext.cs
│   └── Utilisateur.cs
├── Views/                # Vues Razor
│   ├── Home/
│   ├── Account/
│   ├── Produits/
│   └── ...
├── Content/              # Fichiers statiques (CSS, images)
├── Scripts/              # Fichiers JavaScript
├── App_Start/            # Configuration de l'application
├── App_Data/             # Données de l'application
└── Web.config            # Configuration web
```

## 🔧 Configuration

### Variables d'Environnement
- `FrozenInventoryDB` : Chaîne de connexion à la base de données
- `webpages:Version` : Version des pages web
- `ClientValidationEnabled` : Validation côté client

### Sécurité
- Authentification par formulaires configurée
- Timeout de session : 2880 minutes (48 heures)
- URL de connexion : `~/Account/Login`

## 📊 Base de Données

### Tables Principales
- **Utilisateurs** : Gestion des comptes utilisateurs
- **Produits** : Catalogue des produits
- **Clients** : Base de données clients
- **Chambres** : Gestion des chambres froides
- **Mouvements** : Traçabilité des entrées/sorties
- **Factures** : Gestion comptable
- **Paiements** : Suivi des paiements

## 🧪 Tests

### Test de Connexion
Un contrôleur de test est disponible pour vérifier la connexion à la base de données :
- URL : `/TestConnexionBD`
- Vérifie la connectivité SQL Server
- Affiche les informations de connexion

## 🚀 Déploiement

### Développement
1. Utilisez IIS Express (configuré par défaut)
2. Port SSL : 44377
3. Authentification Windows activée

### Production
1. Publiez l'application sur IIS
2. Configurez la chaîne de connexion pour la production
3. Activez la compression et la mise en cache
4. Configurez les certificats SSL

## 🤝 Contribution

### Comment Contribuer
1. Fork le projet
2. Créez une branche pour votre fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Committez vos changements (`git commit -m 'Add some AmazingFeature'`)
4. Push vers la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

### Standards de Code
- Suivez les conventions C# Microsoft
- Utilisez des noms de variables explicites
- Ajoutez des commentaires pour les logiques complexes
- Testez vos modifications avant de soumettre

## 📝 Changelog

### Version 1.0.0
- ✅ Système d'authentification complet
- ✅ Gestion des produits et stocks
- ✅ Interface utilisateur responsive
- ✅ Base de données SQL Server
- ✅ Rapports et analytics

## 📄 Licence

Ce projet est sous licence MIT. Voir le fichier `LICENSE` pour plus de détails.

## 👥 Auteurs

- **Votre Nom** - *Développement initial* - [VotreGitHub](https://github.com/votre-username)

## 🙏 Remerciements

- Équipe de développement ASP.NET
- Communauté Bootstrap
- Contributeurs open source

## 📞 Support

Pour toute question ou problème :
- 📧 Email : votre-email@example.com
- 🐛 Issues : [GitHub Issues](https://github.com/votre-username/FrozenInventorySystem/issues)
- 📖 Documentation : [Wiki du projet](https://github.com/votre-username/FrozenInventorySystem/wiki)

---

⭐ Si ce projet vous a été utile, n'hésitez pas à lui donner une étoile sur GitHub !
