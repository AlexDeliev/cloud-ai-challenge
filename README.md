# Cloud AI Challenge: Image Analysis and Generation App

This project is built as part of the **Microsoft Learn Challenge Project** to integrate image analysis and generation features into a .NET web application using Azure AI services.
![Cloud Project Scheme](https://github.com/user-attachments/assets/0b2997ee-610c-4911-adb6-e82c6a4d035b)

## Project Overview
The application demonstrates how to:
- Analyze images using Azure AI Vision APIs.
- Generate images based on text prompts using Azure OpenAI Service.
- Build a modern, responsive web application with Blazor and .NET.

### Features
1. **Image Analysis**:
   - Upload or provide a URL to an image.
   - Analyze the image to generate captions and crop suggestions.
2. **Image Generation**:
   - Input a descriptive text prompt.
   - Generate an image using the Azure OpenAI Service.
3. **Responsive Design**:
   - Optimized for desktop and mobile devices.

---

## Prerequisites
Ensure the following tools and services are set up:

### Tools
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

### Azure Resources
- [Azure AI Vision](https://azure.microsoft.com/en-us/products/cognitive-services/computer-vision/)
- [Azure OpenAI Service](https://azure.microsoft.com/en-us/products/openai-service/)

---

## Getting Started

### Clone the Repository
```bash
git clone https://github.com/AlexDeliev/cloud-ai-challenge.git
cd cloud-ai-challenge
```

### Set Up Azure Services
1. **Azure AI Vision**:
   - Create an Azure AI Vision resource.
   - Retrieve the `Endpoint` and `Key` from the Azure portal.
   - Set the environment variables:
     ```bash
     export VISION_ENDPOINT=<your-vision-endpoint>
     export VISION_KEY=<your-vision-key>
     ```

2. **Azure OpenAI Service**:
   - Create an Azure OpenAI resource.
   - Retrieve the `Endpoint` and `Key` from the Azure portal.
   - Set the environment variables:
     ```bash
     export OPENAI_ENDPOINT=<your-openai-endpoint>
     export OPENAI_KEY=<your-openai-key>
     ```

### Build and Run the Application
1. Restore dependencies:
   ```bash
   dotnet restore
   ```
2. Run the application:
   ```bash
   dotnet run
   ```
3. Open the application in your browser at `https://localhost:5001`.

---

## Project Structure
```
cloud-ai-challenge/
├── Pages/
│   ├── Home.razor        # Main page for image analysis and generation
│   └── Shared/           # Shared components (e.g., layout, navigation)
├── wwwroot/              # Static files (CSS, images, etc.)
├── Program.cs            # Application entry point
├── appsettings.json      # Configuration file
└── README.md             # Project documentation
```

---

## Deployment
### To Azure App Service
1. Install the Azure CLI: [Get Started](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli)
2. Log in to your Azure account:
   ```bash
   az login
   ```
3. Publish the app:
   ```bash
   dotnet publish -c Release -o ./publish
   az webapp up --name <your-app-name> --resource-group <your-resource-group> --plan <your-app-service-plan>
   ```

---

## Challenges Faced
- **API Integration**: Ensuring the correct setup of Azure resources and handling API responses.
- **Error Handling**: Providing meaningful feedback for null or invalid inputs.
- **UI Design**: Making the interface intuitive and responsive.

---

## Resources
- [Azure AI Vision Documentation](https://learn.microsoft.com/en-us/azure/ai-services/computer-vision/)
- [Azure OpenAI Documentation](https://learn.microsoft.com/en-us/azure/cognitive-services/openai/)
- [Microsoft Learn Module](https://learn.microsoft.com/en-us/training/modules/challenge-project-add-image-analysis-generation-to-app/?WT.mc_id=academic-114319-gwynethp)

---

## License
This project is licensed under the MIT License. See [LICENSE](LICENSE) for more details.

