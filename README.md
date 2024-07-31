# Smart Redaction using Syncfusion Blazor PDF Viewer

This repo contains the example Blazor application which performs redaction smartly using Blazor PDF Viewer and AI.

Here, the sample demonstrates how the Syncfusion Blazor PDF Viewer can intelligently redact sensitive information using AI assistance.

## Before running the sample, ensure you enter the valid keys in the following files:
 
- In `Program.cs`, add your valid Syncfusion license.

 ![image](https://github.com/user-attachments/assets/e01eefbb-a6fd-4fad-aeb7-c445daf8bb82)

- In `AzureOpenAI.cs`, add your endpoint and deployment name.
 
 ![image](https://github.com/user-attachments/assets/aac6fb90-37bd-483b-ad57-7686921eca3c)

- In `SmartRedact.razor`, add your Azure OpenAI key.

![image](https://github.com/user-attachments/assets/15044326-489a-4e45-bf0d-e2e1fb29815d)

## Steps to run the sample:

1.	Running the sample will render the PDF Viewer and load a default PDF document, as shown in the below image.

  ![image](https://github.com/user-attachments/assets/446ec3f3-7f09-42f1-bea6-8f1d687e4017)
 
2.	The **Smart Redact** button opens a pane at the right side, allowing for smart redaction.

  ![image](https://github.com/user-attachments/assets/9fb87246-6069-4baa-8c59-11e393f9e040)

3.	Choose the sensitive patterns to redact from the smart redaction pane and then click the **Scan** button.

4.	The sensitive values for the selected patterns will be displayed in the tree view, and are selected by default.

  ![image](https://github.com/user-attachments/assets/409201f2-6abc-4c63-81be-0d3c8c57863a)

5.	You can check or uncheck the values to redact. Checked values will be highlighted by a rectangle.

  ![image](https://github.com/user-attachments/assets/138afb9d-c566-4109-b501-96e0ef7985d4)

6.	The **Redact** button will be enabled if any value is ready to be redacted. Click the **Redact** button to redact the highlighted content.

  ![image](https://github.com/user-attachments/assets/0956fff7-d2d6-42a9-9a2a-1e1828545365)

7.	Additionally, if the document contains any sensitive information that is not detected by the smart redaction, you can manually redact using the **Mark for Redaction** option.

  ![image](https://github.com/user-attachments/assets/3cc9fec0-ae9c-4075-bc82-024e83d1c944)

* Click the **Mark for Redaction** button in the toolbar, then draw a rectangle over the content you want to redact.
    
  ![image](https://github.com/user-attachments/assets/ca28fc34-04ea-483c-af06-45c9a58bd47a)

* You can mark multiple content as needed.

* Click the **Redact** button to reload the redacted document into the viewer.
    
  ![image](https://github.com/user-attachments/assets/71ab50a1-f890-41f2-9a14-04ceee881de1)

 ![image](https://github.com/user-attachments/assets/6f1402f8-9544-4bdf-b815-c29cba7f9595)