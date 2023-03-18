using System;
using System.Net;
using System.IO;

<script type="text/javascript">
    // Replace the following variables with your own values
    const webhook = 'https://discordapp.com/api/webhooks/XXXXXXXXXX/XXXXXXXXXX'; // Replace with your webhook URL
    const message = 'Hello! This is a message sent by a JavaScript code!'; // Message to be sent
    
    // Don't change anything below this line
    const data = {
      "content": message
    };
    fetch(webhook, {
      method: 'POST',
      body: JSON.stringify(data),
      headers: {
        'Content-Type': 'application/json'
      }
    })
    .then(res => console.log('Message sent!'))
    .catch(err => console.error(err));
</script>