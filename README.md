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

Or set the property `"envMode": "loose"` to include all environment variables.

Or use the `globalEnv` property at the root of the `turbo.json` file.

Next, restart the application in the aspire dashboard and refresh the web page. You should now see the environment variable keys displayed correctly.

You can also set a `turbo.json` file for each app individually by placing it in the app's root directory (e.g., `apps/web/turbo.json`).

## Quick Fix

Simply go to the branch [fix/turbo-env-config](https://github.com/vsantele/aspire-turbo-next-env/tree/fix/turbo-env-config) and restart the web application in the aspire dashboard.

## More Information

- Turborepo: [Package Configuration](https://turborepo.com/docs/reference/package-configurations)
- Turborepo: [Environment Modes](https://turborepo.com/docs/crafting-your-repository/using-environment-variables#environment-modes)
- Turborepo: [Configuring Environment Variables](https://turborepo.com/docs/reference/configuration#env)
- Turborepo: [Configuring Global Environment Variables](https://turborepo.com/docs/reference/configuration#globalenv)
