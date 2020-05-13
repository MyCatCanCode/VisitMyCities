using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.DataModel.DataAccessLayer
{
    public static class DbInitializer
    {
        public static void Initialize(VisitMyCitiesContext context)
        {
            // Créer la base de données locale
            context.Database.EnsureCreated();

            // Voir si la BDD contient déjà des enregistrements de bâtiments
            if (context.Batiments.Any())
            {
                return;   // La BDD est déjà initialisée
            }

            
            var batiments = new Batiment[]
            {
            new Batiment{NomBatiment = "Eglise protestante Saint-Pierre-le-Jeune", Adresse = "Place Saint-Pierre-le-Jeune, 67000 Strasbourg", URLPhoto = "", TypeBatiment = "Eglise", 
                DescriptionBatiment = "Trois églises ont été construites successivement au même endroit. Au début du Moyen-Âge, une petite église, dédiée à Saint Colomban - ou Sainte Colombe ? -, dont il subsiste sous le bas-côté extérieur Sud un caveau. En 1031 fut commencée la construction d’une église romane, pour un chapître de chanoines. Il en reste le cloître et les étages inférieurs du clocher.", 
                Longitude = 7.746713, Latitude = 48.585132, MonumentHistorique = true, DateConstruction = ("1031-01-01"), VilleId=0},
            new Batiment{NomBatiment = "Cathédrale Notre Dame", Adresse = "Place de la Cathédrale, 67000 Strasbourg", URLPhoto = "", TypeBatiment = "Cathédrale", 
                DescriptionBatiment = "De votre premier aperçu de la magnifique structure de pâtés de maisons à une vue époustouflante lorsque vous entrez sur la place qui entoure ce gigantesque monument gothique presque étrange, il est vraiment impressionnant !", 
                Longitude = 0, Latitude = 0, MonumentHistorique = true, DateConstruction = ("1015-01-01"), VilleId=0},
            new Batiment{NomBatiment = "Palais du Rhin", Adresse = "1 Place de la République, 67000 Strasbourg", URLPhoto = "", TypeBatiment = "Palais", 
                DescriptionBatiment = "Le palais du Rhin, ancien palais impérial, se situe à Strasbourg, dans la Neustadt, sur la place de la République qu’il domine de son imposante coupole. Avec le grand jardin qui l’entoure et les anciennes écuries situées derrière le bâtiment, il forme l’un des ensembles les plus complets et les plus emblématiques de l'architecture allemande de la fin du XIXᵉ siècle.", 
                Longitude = 0, Latitude = 0, MonumentHistorique = true, DateConstruction = ("1883-01-01"), VilleId=0},
            new Batiment{NomBatiment = "Le Pont de l'Europe", Adresse = "", URLPhoto = "", TypeBatiment = "Pont", 
                DescriptionBatiment = "Le pont de l'Europe de Strasbourg - Kehl est un pont routier frontalier entre l'Allemagne et la France au-dessus du Rhin", 
                Longitude = 0, Latitude = 0, MonumentHistorique = false, DateConstruction = ("2005-09-01"), VilleId=0},
            new Batiment{NomBatiment = "Église Catholique Saint-Pierre-le-Vieux de Strasbourg", Adresse= "Place Saint-Pierre-le-Vieux, 67000 Strasbourg", URLPhoto = "", TypeBatiment = "Eglise", 
                DescriptionBatiment = "L'église Saint-Pierre-le-Vieux de Strasbourg se situe place Saint-Pierre-le-Vieux, au bout de la rue du 22-Novembre et de la Grand'rue dans le centre historique de la ville. La partie de l'église côté rue du 22-Novembre est affectée au culte catholique tandis que la partie donnant sur la Grand'rue est affectée au culte protestant.", 
                Longitude = 0, Latitude = 0, MonumentHistorique = true, DateConstruction = ("2005-09-01"), VilleId=0},
            new Batiment{NomBatiment = "Musée Zoologique de Strasbourg", Adresse ="29 Boulevard de la Victoire, 67000 Strasbourg", URLPhoto = "", TypeBatiment = "Musée", 
                DescriptionBatiment = "Le musée zoologique de la ville de Strasbourg présente des collections de zoologie appartenant à la ville de Strasbourg et gérées par l'université de Strasbourg. Il est situé boulevard de la Victoire à proximité du campus historiquehd                                                          ", 
                Longitude = 0, Latitude = 0, MonumentHistorique = false, DateConstruction = ("1804-01-01"), VilleId=0},

            };
            foreach (Batiment b in batiments)
            {
                context.Batiments.Add(b);
            }
            context.SaveChanges();

            var detailsArchi = new DetailArchitectural[]
            {
                new DetailArchitectural{NomDetail="Orgue", 
                    DescriptionDetail="Orgue de Jean André Silbermann (restauré en 1950 et 1966) dont la notoriété dépasse la région. Helmut Walcha y a enregistré un grand nombre de ses interprétations des œuvres pour orgue de Bach.", BatimentId=0},
                new DetailArchitectural{NomDetail="Portail principal", 
                    DescriptionDetail="En 1897-1901 l'église, en partie ruinée, fut complètement restaurée par le professeur Carl Schäfer (de), professeur à la Technische Hochschule de Karlsruhe. L'entrée entre autres fut alors déplacée latéralement et un nouveau portail principal fut créé, sur le modèle du portail nord de la façade de la cathédrale de Strasbourg.", BatimentId=0},
                new DetailArchitectural{NomDetail="Vitraux", 
                    DescriptionDetail="Vitraux des Empereurs.", BatimentId=1},
                new DetailArchitectural{NomDetail="Tapisseries", 
                    DescriptionDetail="Tapisseries du xviie siècle représentant les Scènes de la vie de la Vierge.", BatimentId=1},
                new DetailArchitectural{NomDetail="Horloge Astronomique", 
                    DescriptionDetail="L'Horloge astronomique de la Cathédrale Notre-Dame de Strasbourg est un chef-d'œuvre de la Renaissance, considéré à l'époque comme faisant partie des sept merveilles de l'Allemagne1. Elle est classée monument historique depuis le 15 avril 1987.", BatimentId=1},
                new DetailArchitectural{NomDetail="Autel", 
                    DescriptionDetail="Autel baroque de la chapelle Saint-Laurent.", BatimentId=1},
                new DetailArchitectural{NomDetail="Hall d'entrée", 
                    DescriptionDetail="Au rez-de-chaussée, le hall d'entrée s'ouvre sur deux vestibules latéraux surélevés conduisant aux doubles appartements réservés, à l'origine, à un couple princier, au sud, et à un hôte de marque, au nord.", BatimentId=2},
                new DetailArchitectural{NomDetail="Décor du salon de l'impératrice", 
                    DescriptionDetail="Le décor du salon de l'impératrice, d'esprit rococo, se démarque résolument de l'inspiration Renaissance qui a présidé à la décoration intérieure. Le plafond peint, les portes blanches rechampies surmontées de panneaux peints et la cheminée en marbre blanc confèrent à l'ensemble une atmosphère chaleureuse et gaie qui contraste avec les autres pièces du palais.", BatimentId=2},
                new DetailArchitectural{NomDetail="Reconstitution", 
                    DescriptionDetail="Reconstitution du cabinet d'histoire naturelle de Jean Hermann avec de nombreux documents et spécimens d'époque en situation.", BatimentId=5},
                new DetailArchitectural{NomDetail="Collections", 
                    DescriptionDetail="Le musée présente des collections très variées et riches d'oiseaux, mammifères, invertébrés marins et insectes, avec un accent tout particulier sur la faune alsacienne.", BatimentId=5}
            };

            foreach (DetailArchitectural d in detailsArchi)
            {
                context.DetailsArchi.Add(d);
            }
            context.SaveChanges();

            var villes = new Ville[]
            {
                new Ville{NomVille="Strasbourg", NomRegion="Alsace(Grand-Est)", NumDepartement=67, NomDepartement="Bas-Rhin"}
            };

            foreach (Ville v in villes)
            {
                context.Villes.Add(v);
            }
            context.SaveChanges();
        }
    }
}
