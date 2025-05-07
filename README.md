# Brain Tumor Classifier Web App

This is a Blazor (.NET 8) web application for brain tumor classification using a deep learning model deployed on Azure Machine Learning. Users can upload a brain MRI image, and the app will display the predicted tumor type and confidence scores in a popup.

## Features

- **Image Upload:** Upload brain MRI images securely from your browser.
- **Azure ML Integration:** Sends images to a deployed Azure ML endpoint for prediction.
- **Prediction Results:** Displays model confidence for each tumor type in a popup.
- **Modern UI:** Built with Blazor (.NET 8) and C#.
- **Secure Configuration:** Sensitive keys and endpoints are kept out of source control.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022+ or VS Code
- An [Azure ML endpoint](https://learn.microsoft.com/en-us/azure/machine-learning/how-to-deploy-online-endpoint) with your trained model

### Setup

1. **Clone the repository:**
git clone https://github.com/yourusername/brain-tumor-classifier.git
cd brain-tumor-classifier

2. **Restore dependencies:**
dotnet restore

3. **Add your Azure ML endpoint and API key:**
- Copy `appsettings.example.json` to `appsettings.json`.
- Fill in your Azure ML `ApiKey` and `EndpointUrl`:
  ```
  {
    "AzureML": {
      "ApiKey": "YOUR_AZURE_ML_KEY",
      "EndpointUrl": "YOUR_AZURE_ML_ENDPOINT_URL"
    }
  }
  ```

4. **Run the app:**
dotnet run

or press **F5** in Visual Studio.

5. **Open in your browser:**  
Navigate to `https://localhost:5001` (or the URL shown in your terminal).

### Usage

1. Go to the **Brain Tumor Prediction** page.
2. Upload a brain MRI image (JPEG/PNG).
3. Wait for the prediction popup to display the model’s confidence for each tumor type.

### Configuration

- **API keys and endpoints** are read from `appsettings.json` (which is gitignored).
- For production, use environment variables or Azure Key Vault for secrets.

### Security

- **Never commit secrets** (API keys, real `appsettings.json`) to your repository.
- Use `appsettings.example.json` as a template for configuration.

### Dependencies

- [Azure ML](https://azure.microsoft.com/en-us/products/machine-learning/)
- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)

**Enjoy using the Brain Tumor Classifier Web App!**
