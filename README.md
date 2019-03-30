# Streaming Speech to Text for Magic Leap

I recently got Azure Streaming Speech Recognition working on Magic Leap. I started with an example project from Microsoft, and made a number of changes (like removing dynamics, which aren't supported on AOT), switching to UnityWebRequests for authentication, and fixing a few bugs that occured when making more than one request.

All you'll need to run this example is an API key. You can create an Azure account, and get an API key, here: https://portal.azure.com/
