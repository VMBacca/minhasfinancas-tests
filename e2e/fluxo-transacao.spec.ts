import { test, expect } from "@playwright/test";

test("Fluxo básico de criação de transação", async ({ page }) => {
  await page.goto("http://localhost:3000");

  // cria pessoa
  await page.click("text=Nova Pessoa");
  await page.fill('input[name="nome"]', "Teste Usuario");
  await page.fill('input[name="cpf"]', "12345678900");
  await page.click("text=Salvar");

  // cria categoria
  await page.click("text=Nova Categoria");
  await page.fill('input[name="nome"]', "Mercado");
  await page.selectOption('select[name="finalidade"]', "Despesa");
  await page.click("text=Salvar");

  // cria transação
  await page.click("text=Nova Transação");
  await page.fill('input[name="valor"]', "100");
  await page.click("text=Salvar");

  // verifica se aparece na tela
  await expect(page.locator("text=100")).toBeVisible();
});
