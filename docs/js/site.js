(function () {
  "use strict";

  function getArticle() {
    return document.querySelector(".md-content__inner .md-typeset");
  }

  function getHeroAnchor(title) {
    return title.closest(".h1-copy-wrapper") || title;
  }

  function enhanceHome(article, title) {
    if (!article.querySelector(".docs-hero-lead")) {
      const lead = document.createElement("p");
      lead.className = "docs-hero-lead";
      lead.textContent =
        "Official .NET SDK for text to speech, speech to text, voice cloning, sound generation, and realtime transcription.";
      getHeroAnchor(title).insertAdjacentElement("afterend", lead);
    }

    const badgeRow = Array.from(article.children).find(
      (element) => element.tagName === "P" && element.querySelector("img")
    );
    if (badgeRow) {
      badgeRow.classList.add("docs-badge-row");
    }

    if (!article.querySelector(".docs-hero-actions")) {
      const actions = document.createElement("div");
      actions.className = "docs-hero-actions";
      actions.innerHTML = [
        '<a href="#usage">Get started</a>',
        '<a href="./examples/text-to-speech/">Open examples</a>',
      ].join("");

      const insertionTarget = badgeRow || article.querySelector(".docs-hero-lead");
      if (insertionTarget) {
        insertionTarget.insertAdjacentElement("afterend", actions);
      }
    }

    const featuresHeading = Array.from(article.children).find(
      (element) => element.tagName === "H2" && element.textContent.trim().startsWith("Features")
    );
    if (featuresHeading?.nextElementSibling?.tagName === "UL") {
      const featureList = featuresHeading.nextElementSibling;
      featureList.classList.add("docs-feature-grid");
      Array.from(featureList.children).forEach((item) => {
        item.classList.add("docs-feature-card");
      });
    }

    if (article.dataset.docsHomeSectionsWrapped === "true") {
      return;
    }

    let currentSection = null;
    for (const child of Array.from(article.children)) {
      if (child.classList?.contains("docs-hero-lead") || child.classList?.contains("docs-hero-actions")) {
        continue;
      }

      if (child.tagName === "H3") {
        currentSection = document.createElement("section");
        currentSection.className = "docs-section-card";
        article.insertBefore(currentSection, child);
        currentSection.appendChild(child);
        continue;
      }

      if (child.tagName === "H2") {
        currentSection = null;
        continue;
      }

      if (currentSection) {
        currentSection.appendChild(child);
      }
    }

    article.dataset.docsHomeSectionsWrapped = "true";
  }

  function enhanceExample(article, title) {
    if (article.dataset.docsExampleShellWrapped === "true") {
      return;
    }

    const heroAnchor = getHeroAnchor(title);
    const shell = document.createElement("div");
    shell.className = "docs-example-shell";
    heroAnchor.insertAdjacentElement("afterend", shell);

    const children = Array.from(article.children);
    const anchorIndex = children.indexOf(heroAnchor);
    for (const sibling of children.slice(anchorIndex + 1)) {
      if (sibling === shell) {
        continue;
      }

      shell.appendChild(sibling);
    }

    article.dataset.docsExampleShellWrapped = "true";
  }

  function enhancePage() {
    const article = getArticle();
    if (!article) {
      return;
    }

    const title = article.querySelector("h1");
    if (!title) {
      return;
    }

    const isHome = title.textContent.trim() === "ElevenLabs";
    document.body.classList.toggle("docs-home", isHome);
    document.body.classList.toggle("docs-example", !isHome);

    if (isHome) {
      enhanceHome(article, title);
      return;
    }

    enhanceExample(article, title);
  }

  if (typeof document$ !== "undefined") {
    document$.subscribe(enhancePage);
  } else if (document.readyState === "loading") {
    document.addEventListener("DOMContentLoaded", enhancePage);
  } else {
    enhancePage();
  }
})();
