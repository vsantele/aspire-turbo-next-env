import styles from "./page.module.css"

export default async function Home() {
  const testEnvKeys = Object.keys(process.env)
    .filter((n) => n.startsWith("TEST_"))
    .sort()

  return (
    <div className={styles.page}>
      <main className={styles.main}>
        <h1 className={styles.title}>
          This is a sample app for{" "}
          <a href="https://github.com/CommunityToolkit/Aspire/issues/1083">
            https://github.com/CommunityToolkit/Aspire/issues/1083
          </a>
        </h1>
        <p>
          Environment Keys starting with <code>TEST_</code>:
        </p>
        <ul>
          {testEnvKeys.map((key: string) => (
            <li key={key}>{key}</li>
          ))}
        </ul>
      </main>
    </div>
  )
}
