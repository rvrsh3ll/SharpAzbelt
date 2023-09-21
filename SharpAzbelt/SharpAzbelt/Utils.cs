﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SharpAzbelt
{
    class Utils
    {
        public static Dictionary<string, string> Appids = new Dictionary<string, string>() {
            {"23523755-3a2b-41ca-9315-f81f3f566a95", "ACOM Azure Website"},
            {"69893ee3-dd10-4b1c-832d-4870354be3d8", "AEM-DualAuth"},
            {"0cb7b9ec-5336-483b-bc31-b15b5788de71", "ASM Campaign Servicing"},
            {"7b7531ad-5926-4f2d-8a1d-38495ad33e17", "Azure Advanced Threat Protection"},
            {"e9f49c6b-5ce5-44c8-925d-015017e9f7ad", "Azure Data Lake"},
            {"499b84ac-1321-427f-aa17-267ca6975798", "Azure DevOps"},
            {"835b2a73-6e10-4aa5-a979-21dfda45231c", "Azure Lab Services Portal"},
            {"c44b4083-3bb0-49c1-b47d-974e53cbdf3c", "Azure Portal"},
            {"37182072-3c9c-4f6a-a4b3-b3f91cacffce", "AzureSupportCenter"},
            {"9ea1ad79-fdb6-4f9a-8bc3-2b70f96e34c7", "Bing"},
            {"bb2a2e3a-c5e7-4f0a-88e0-8e01fd3fc1f4", "CPIM Service"},
            {"e64aa8bc-8eb4-40e2-898b-cf261a25954f", "CRM Power BI Integration"},
            {"00000007-0000-0000-c000-000000000000", "Dataverse"},
            {"60c8bde5-3167-4f92-8fdb-059f6176dc0f", "Enterprise Roaming and Backup"},
            {"a57aca87-cbc0-4f3c-8b9e-dc095fdc8978", "IAM Supportability"},
            {"16aeb910-ce68-41d1-9ac3-9e1673ac9575", "IrisSelectionFrontDoor"},
            {"d73f4b35-55c9-48c7-8b10-651f6f2acb2e", "MCAPI Authorization Prod"},
            {"944f0bd1-117b-4b1c-af26-804ed95e767e", "Media Analysis and Transformation Service"},
            {"0cd196ee-71bf-4fd6-a57c-b491ffd4fb1e", "Media Analysis and Transformation Service"},
            {"ee272b19-4411-433f-8f28-5c13cb6fd407", "Microsoft 365 Support Service"},
            {"0000000c-0000-0000-c000-000000000000", "Microsoft App Access Panel"},
            {"65d91a3d-ab74-42e6-8a2f-0add61688c74", "Microsoft Approval Management"},
            {"38049638-cc2c-4cde-abe4-4479d721ed44", "Microsoft Approval Management"},
            {"29d9ed98-a469-4536-ade2-f981bc1d605e", "Microsoft Authentication Broker"},
            {"04b07795-8ddb-461a-bbee-02f9e1bf7b46", "Microsoft Azure CLI"},
            {"1950a258-227b-4e31-a9cf-717495945fc2", "Microsoft Azure PowerShell"},
            {"cf36b471-5b44-428c-9ce7-313bf84528de", "Microsoft Bing Search"},
            {"2d7f3606-b07d-41d1-b9d2-0d0c9296a6e8", "Microsoft Bing Search for Microsoft Edge"},
            {"1786c5ed-9644-47b2-8aa0-7201292175b6", "Microsoft Bing Default Search Engine"},
            {"3090ab82-f1c1-4cdf-af2c-5d7a6f3e2cc7", "Microsoft Defender for Cloud Apps"},
            {"18fbca16-2224-45f6-85b0-f7bf2b39b3f3", "Microsoft Learn"},
            {"00000015-0000-0000-c000-000000000000", "Microsoft Dynamics ERP"},
            {"6253bca8-faf2-4587-8f2f-b056d80998a7", "Microsoft Edge Insider Addons Prod"},
            {"00000007-0000-0ff1-ce00-000000000000", "Microsoft Exchange Online Protection"},
            {"c9a559d2-7aab-4f13-a6ed-e7e9c52aec87", "Microsoft Forms"},
            {"00000003-0000-0000-c000-000000000000", "Microsoft Graph"},
            {"74bcdadc-2fdc-4bb3-8459-76d06952a0e9", "Microsoft Intune Web Company Portal"},
            {"fc0f3af4-6835-4174-b806-f7db311fd2f3", "Microsoft Intune Windows Agent"},
            {"d3590ed6-52b3-4102-aeff-aad2292ab01c", "Microsoft Office"},
            {"00000006-0000-0ff1-ce00-000000000000", "Microsoft Office 365 Portal"},
            {"67e3df25-268a-4324-a550-0de1c7f97287", "Microsoft Office Web Apps Service"},
            {"d176f6e7-38e5-40c9-8a78-3998aab820e7", "Microsoft Online Syndication Partner Portal"},
            {"93625bc8-bfe2-437a-97e0-3d0060024faa", "Microsoft password reset service"},
            {"871c010f-5e61-4fb1-83ac-98610a7e9110", "Microsoft Power BI"},
            {"28b567f6-162c-4f54-99a0-6887f387bbcc", "Microsoft Storefronts"},
            {"cf53fce8-def6-4aeb-8d30-b158e7b1cf83", "Microsoft Stream Portal"},
            {"98db8bd6-0cc0-4e67-9de5-f187f1cd1b41", "Microsoft Substrate Management"},
            {"fdf9885b-dd37-42bf-82e5-c3129ef5a302", "Microsoft Support"},
            {"1fec8e78-bce4-4aaf-ab1b-5451cc387264", "Microsoft Teams"},
            {"cc15fd57-2c6c-4117-a88c-83b1d56b4bbe", "Microsoft Teams Services"},
            {"5e3ce6c0-2b1f-4285-8d4b-75ee78787346", "Microsoft Teams Web Client"},
            {"95de633a-083e-42f5-b444-a4295d8e9314", "Microsoft Whiteboard Services"},
            {"4345a7b9-9a63-4910-a426-35363201d503", "O365 Suite UX"},
            {"00000002-0000-0ff1-ce00-000000000000", "Office 365 Exchange Online"},
            {"00b41c95-dab0-4487-9791-b9d2c32c80f2", "Office 365 Management"},
            {"66a88757-258c-4c72-893c-3e8bed4d6899", "Office 365 Search Service"},
            {"00000003-0000-0ff1-ce00-000000000000", "Office 365 SharePoint Online"},
            {"94c63fef-13a3-47bc-8074-75af8c65887a", "Office Delve"},
            {"93d53678-613d-4013-afc1-62e9e444a0a5", "Office Online Add-in SSO"},
            {"2abdc806-e091-4495-9b10-b04d93c3f040", "Office Online Client AAD- Augmentation Loop"},
            {"b23dd4db-9142-4734-867f-3577f640ad0c", "Office Online Client AAD- Loki"},
            {"17d5e35f-655b-4fb0-8ae6-86356e9a49f5", "Office Online Client AAD- Maker"},
            {"b6e69c34-5f1f-4c34-8cdf-7fea120b8670", "Office Online Client MSA- Loki"},
            {"243c63a3-247d-41c5-9d83-7788c43f1c43", "Office Online Core SSO"},
            {"a9b49b65-0a12-430b-9540-c80b3332c127", "Office Online Search"},
            {"4b233688-031c-404b-9a80-a4f3f2351f90", "Office.com"},
            {"89bee1f7-5e6e-4d8a-9f3d-ecd601259da7", "Office365 Shell WCSS-Client"},
            {"0f698dd4-f011-4d23-a33e-b36416dcb1e6", "OfficeClientService"},
            {"4765445b-32c6-49b0-83e6-1d93765276ca", "OfficeHome"},
            {"4d5c2d63-cf83-4365-853c-925fd1a64357", "OfficeShredderWacClient"},
            {"62256cef-54c0-4cb4-bcac-4c67989bdc40", "OMSOctopiPROD"},
            {"ab9b8c07-8f02-4f72-87fa-80105867a763", "OneDrive SyncEngine"},
            {"2d4d3d8e-2be3-4bef-9f87-7875a61c29de", "OneNote"},
            {"27922004-5251-4030-b22d-91ecd9a37ea4", "Outlook Mobile"},
            {"a3475900-ccec-4a69-98f5-a65cd5dc5306", "Partner Customer Delegated Admin Offline Processor"},
            {"bdd48c81-3a58-4ea9-849c-ebea7f6b6360", "Password Breach Authenticator"},
            {"00000009-0000-0000-c000-000000000000", "Power BI Service"},
            {"ffcb16e8-f789-467c-8ce9-f826a080d987", "SharedWithMe"},
            {"08e18876-6177-487e-b8b5-cf950c1e598c", "SharePoint Online Web Client Extensibility"},
            {"b4bddae8-ab25-483e-8670-df09b9f1d0ea", "Signup"},
            {"00000004-0000-0ff1-ce00-000000000000", "Skype for Business Online"},
            {"905fcf26-4eb7-48a0-9ff0-8dcc7194b5ba", "Sway"},
            {"268761a2-03f3-40df-8a8b-c3db24145b6b", "Universal Store Native Client"},
            {"5572c4c0-d078-44ce-b81c-6cbf8d3ed39e", "Vortex [wsfed enabled]"},
            {"00000002-0000-0000-c000-000000000000", "Windows Azure Active Directory"},
            {"797f4846-ba00-4fd7-ba43-dac1f8f63013", "Windows Azure Service Management API"},
            {"a3b79187-70b2-4139-83f9-6016c58cd27b", "WindowsDefenderATP Portal"},
            {"26a7ee05-5602-4d76-a7ba-eae8b7b67941", "Windows Search"},
            {"1b3c667f-cde3-4090-b60b-3d2abd0117f0", "Windows Spotlight"},
            {"45a330b1-b1ec-4cc1-9161-9f03992aa49f", "Windows Store for Business"},
            {"00000005-0000-0ff1-ce00-000000000000", "Yammer"},
            {"c1c74fed-04c9-4704-80dc-9f79a2e515cb", "Yammer Web"},
            {"e1ef36fd-b883-4dbf-97f0-9ece4b576fc6", "Yammer Web Embed"}
        };
        public class Jwt
        {
            public string aud { get; set; }
            public string iss { get; set; }
            public int iat { get; set; }
            public int nbf { get; set; }
            public int exp { get; set; }
            public string acr { get; set; }
            public string aio { get; set; }
            public string altsecid { get; set; }
            public string[] amr { get; set; }
            public string appid { get; set; }
            public string appidacr { get; set; }
            public string email { get; set; }
            public string idp { get; set; }
            public string ipaddr { get; set; }
            public string rh { get; set; }
            public string scp { get; set; }
            public string sub { get; set; }
            public string tid { get; set; }
            public string unique_name { get; set; }
            public string uti { get; set; }
            public string ver { get; set; }
        }

        public static Jwt ProcessJWT(string jwt)
        {
            string tokenPayload = jwt.Split('.')[1];
            // do we need to pad with '='s?
            for (int i = 0; i < (tokenPayload.Length % 4); i++)
                tokenPayload += '=';
            var tokenJsonBytes = Convert.FromBase64String(tokenPayload);
            string tokenJson = Encoding.Default.GetString(tokenJsonBytes);

            return JsonSerializer.Deserialize<Jwt>(tokenJson);
        }
    }
}
