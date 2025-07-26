<h1 align="center">📍 RotaAI Mobile App</h1>

<p align="center">
  <img src="https://github.com/user-attachments/assets/df1e2d7b-26d5-4dec-be34-63707be3f653" alt="RotaAI Logo" width="250"/>
</p>

---

## 🌐 Overview (EN)

**RotaAI** is an AI-powered mobile application developed for the **2025 TEKNOFEST Technology Competition**, where it became a **semi-finalist in the Tourism category**. The app suggests personalized historical travel routes based on the user's visit history and ratings.

The AI recommendation system, developed in Python, analyzes a user's previous visits and suggests the top 5 most relevant new destinations. As part of the data, we used **web scraping** to collect real Google reviews of historical places.

### 🧭 The app also includes:

- 🇹🇷 Informational pages about **Turkey and TRNC** (history, geography, culture)
- 🍽️ **Traditional Dishes** page introducing regional foods and desserts
- 🧠 A “**Did You Know?**” section on the homepage that presents surprising facts about historical sites

The app is connected to a database and requires user login for personalized functionality.

---

## 🇹🇷 Proje Özeti (TR)

📱 **RotaAI**, kullanıcıların geçmiş ziyaretlerini puanlamasıyla çalışan yapay zeka destekli bir rota öneri mobil uygulamasıdır.  
**2025 TEKNOFEST yarışması TURİZM kategorisinde yarı finalist** olduk. Sistem, Python tabanlı öneri motoruyla kullanıcının geçmiş gezilerine göre en uygun 5 yeni noktayı önerir.

Web scraping yöntemi ile **Google yorumlarından** veri toplayarak tarihi yerlerin kullanıcı yorumlarını elde ettik ve öneri sisteminde örnek veri olarak kullandık.

### 📌 Ek olarak uygulamada şu bölümler yer alır:

- 🇹🇷 Türkiye ve KKTC hakkında tanıtım sayfaları (tarih, kültür, coğrafya)
- 🍽️ Yöresel tatlar sayfası (yemek/tatlı tanıtımları)
- 🧠 Ana sayfada “**Bunları biliyor muydunuz?**” alanı (ilginç bilgiler)

Uygulama kullanıcı girişi ile çalışmakta ve veritabanına bağlıdır.

---

## 🛠️ Technologies Used

- Flutter (Frontend – Mobile)
- ASP.NET Core (Backend & API)
- Python (AI-based recommendation system)
- Web Scraping (Google Reviews)
- JSON (Data exchange)
- MSSQL (Database)

---

## 💡 AI Recommendation System

- Developed in Python using **content-based filtering** (TF-IDF + Cosine Similarity)
- Takes user visit history and ratings (0–5) as input
- Suggests the top 5 most similar historical places
- Includes **sentiment analysis** on review data (Positive / Neutral / Negative)

---

## 📱 App Screenshots

<p align="center"> 
  <img src="https://github.com/user-attachments/assets/a6b276bf-f793-475f-a060-1ea70bf42083" width="300"/> 
  <img src="https://github.com/user-attachments/assets/b02ff6ec-3350-4c56-b371-3aa5919fe0ee" width="300"/><br><br> 
  <img src="https://github.com/user-attachments/assets/fac54143-8dd9-4913-a3a3-bca3929a8d07" width="300"/> 
  <img src="https://github.com/user-attachments/assets/43af257c-796c-4e48-acd1-aec991fd2bd4" width="300"/><br><br> 
  <img src="https://github.com/user-attachments/assets/2a82ed2a-5cb7-4de3-b24f-f558159d5e7e" width="300"/> 
  <img src="https://github.com/user-attachments/assets/65c81b5f-e629-4881-a20f-f7a45438c442" width="300"/><br><br>
</p>

---

## 🚀 Getting Started
⚠️ Important Note:
For the project to run properly, first start the backend (ASP.NET Core API).
The backend program must remain running while you run the Flutter app to ensure the app can communicate with it.

```bash

### 📦 1. Clone the Project
git clone https://github.com/AhmetFurkanRsbr/RotaAI-MobileApp.git

### 🗃️ 2. Restore MSSQL Database (rotaai_demo.bacpac)
- Open SQL Server Management Studio (SSMS)
- Right-click on "Databases" → "Import Data-tier Application"
- Select `rotaai_demo.bacpac` and complete the wizard

# Open the project in your preferred IDE (e.g., VS Code or Android Studio)

### 🤖 3. Run the AI Recommendation System (Python Backend)
cd RotaAI-backend/TeknofestBackendCsharp/PythonScripts

# Install dependencies
pip install -r requirements.txt

### 🛠️ 4. Run the Backned (asp.net API Backend)
cd ..
cd ..
dotnet run

### 📱 5. Run the Flutter App
# Go back to root folder
cd ..
cd .\RotaAI-frontend\

# Install Flutter dependencies
flutter pub get

# Run the app
flutter run
