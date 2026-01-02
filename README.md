# Reproduction App for [CommunityToolkit/Aspire#1082](https://github.com/CommunityToolkit/Aspire/issues/1082)

This is a minimal reproduction app for the issue described in [CommunityToolkit/Aspire#1082](https://github.com/CommunityToolkit/Aspire/issues/1082).

It demonstrates the problem with environment variables not being accessible in a Turbo Next.js application when using Aspire Hosting JavaScript extensions.
To run the app, follow these steps:

1. Clone the repository.
2. Navigate to the project directory.
3. Install dependencies using `pnpm install`.
4. Start the application using `aspire run`.
5. Open your browser and navigate to `http://localhost:3000` to access the web application.
6. See the empty list of environment variable keys starting with `TEST_` displayed on the page.

To fix the issue, you can modify the [`turbo.json`](./turbo.json) file and add the following configuration under the `tasks.dev` section :

```json
      "env": [
        "TEST_*"
      ]
```

Next, restart the application in the aspire dashboard and refresh the web page. You should now see the environment variable keys displayed correctly.
