const makeHtmlAttributes = (attributes) => {
  if (!attributes) {
    return '';
  }
  const keys = Object.keys(attributes);
  // eslint-disable-next-line no-param-reassign
  return keys.reduce(
    (result, key) => (result += ` ${key}="${attributes[key]}"`),
    ''
  );
};

/** @type {(options: import('@rollup/plugin-html').RollupHtmlOptions, entryPointWhitelist: string[]) => string} */
export const indexHtml = (
  { attributes, meta, title, files, publicPath, fileName },
  entryPointWhitelist
) => {
  const scripts = (files.js || [])
    .filter((f) => entryPointWhitelist.some((e) => f.fileName.includes(e)))
    .map(({ fileName }) => {
      const attrs = makeHtmlAttributes(attributes.script);
      return `<script src="${publicPath}${fileName}"${attrs}></script>`;
    })
    .join('\n');
  const links = (files.css || [])
    .map(({ fileName }) => {
      const attrs = makeHtmlAttributes(attributes.link);
      return `<link href="${publicPath}${fileName}" rel="stylesheet"${attrs}>`;
    })
    .join('\n');
  const metas = meta
    .map((input) => {
      const attrs = makeHtmlAttributes(input);
      return `<meta${attrs}>`;
    })
    .join('\n');

  return `
    <!DOCTYPE html>
    <html ${makeHtmlAttributes(attributes.html)}>
      <head>
        <meta name="viewport" content="width=device-width, minimum-scale=1.0" />
        <meta charset="utf-8">
        <link rel="shortcut icon">
        <base href="/">
        <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Material+Icons&display=block" rel="stylesheet">
        ${metas}
        <title>${title}</title>
        ${links}
        <style>
          html, body {
            display: flex;
            flex-direction: column;
            flex: 1;
            margin: 0;
            min-height: 100%;
          }
          
          body {  
            --on: inherit;
            --off: ;
            
            --light: var(--on);
            --dark: var(--off);
            
            --hroLightShade: var(--light, var(--hro4)) var(--dark, var(--hro2));
            --hroLightAccent: var(--light, var(--hro5)) var(--dark, var(--hro1));
            --hroMain: var(--light, var(--hro9)) var(--dark, var(--hro9));
            --hroDarkAccent: var(--light, var(--hro2)) var(--dark, var(--hro4));
            --hroDarkShade: var(--light, var(--hro1)) var(--dark, var(--hro5));
            --hroText: var(--light, var(--hro2)) var(--dark, var(--hro4));

            --mdc-theme-primary: var(--hroMain);
            --mdc-theme-secondary: var(--hroDarkAccent);
            --mdc-theme-surface: var(--hroLightAccent);
            --mdc-theme-background: var(--hroLightShade);

            /* Raw are RGB versions. Useful to compose more complex colors ex: rgba(var(--hro0-raw), .2) */
            --hro0-raw: 74, 75, 81;
            --hro1-raw: 86, 87, 94;
            --hro2-raw: 51, 52, 56;
            --hro3-raw: 32, 34, 36;
            --hro4-raw: 240, 247, 252;
            --hro5-raw: 218, 226, 232;
            --hro6-raw: 170, 181, 191;
            --hro7-raw: 242, 79, 19;
            --hro8-raw: 242, 190, 34;
            --hro9-raw: 242, 79, 19;
            --hro10-raw: 242, 79, 19;
            --hro11-raw: 230, 197, 103;
            --hro12-raw: 68, 126, 179;
            --hro13-raw: 161, 205, 68;
            --hro14-raw: 217, 56, 48;
            --hro15-raw: 245, 133, 127;

            /* Duplicated for better ergonomics in devtools */
            /* Dark colors. */
            --hro0: rgb(74, 75, 81);
            --hro1: rgb(86, 87, 94);
            --hro2: rgb(51, 52, 56);
            --hro3: rgb(32, 34, 36);

            /* Light colors. */
            --hro4: rgb(240, 247, 252);
            --hro5: rgb(218, 226, 232);
            --hro6: rgb(170, 181, 191);

            /* Primary colors. */
            --hro7: rgb(242, 79, 19);
            --hro8: rgb(242, 190, 34);
            --hro9: rgb(242, 79, 19);
            --hro10: rgb(242, 79, 19);
            
            /* Action colors. */
            --hro11: rgb(230, 197, 103);
            --hro12: rgb(68, 126, 179);
            --hro13: rgb(161, 205, 68);
            --hro14: rgb(217, 56, 48);
            --hro15: rgb(245, 133, 127);
            
            background-color: var(--hroLightShade);
            color: var(--hroText);

            font-family: roboto;

          }
          
          @media (prefers-color-scheme: dark) {
            body {
              --light: var(--off);
              --dark: var(--on);
            }
          }
        </style>
      </head>
      <body>
        <hro-app></hro-app>
        ${scripts}
      </body>
    </html>`;
};
