export const dynamic = 'force-static'

export async function GET() {
  const testEnvKeys = Object.keys(process.env).filter(n => n.startsWith("TEST_")).sort();
  return Response.json({ keys: testEnvKeys })
}