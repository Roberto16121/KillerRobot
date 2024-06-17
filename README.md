# KillerRobot

## About
  Proiectul e realizat folosing Console Application. Acesta este împarțit în mai multe clase. 
  
  Enunț :
  
Killer Robot are misiunea de a elimina toate formele de viață de pe planeta Pământ.
Robotul are un laser în ochi cu intensitate variabilă și poate să-și selecteze țintele dintre animale, oameni, etc.
Misiunea robotului este de a distruge toate țintele sale

## Principalele clase 
### GiantKillerRobot
  Este clasa de baza a Robotului în care se stochează proprietățile acestuia cât și metodele aferente.
### LifeForm
  Se stochează viața și implementează metode pentru GetHealth și TakeDamage
  Aici avem diferite clase moștenite din LifeForm, precum Animal, Human și Superhuman
### Planet
  Stochează toate formele de viață
### Render
  Aici se află metode pentru a vedea toate formele de viață și câtă viață mai au, cât și ținta robotului
