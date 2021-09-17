import babel from '@rollup/plugin-babel';
import commonjs from '@rollup/plugin-commonjs';
import html from '@rollup/plugin-html';
import resolve from '@rollup/plugin-node-resolve';
import copy from 'rollup-plugin-copy';
import dev from 'rollup-plugin-dev';
import livereload from 'rollup-plugin-livereload';
import minifyHTML from 'rollup-plugin-minify-html-literals';
import { terser } from 'rollup-plugin-terser';
import { indexHtml } from './src/indexHtml.js';

const extensions = ['.js', '.ts'];

/** @type {import('rollup-plugin-copy').CopyOptions} */
const copyConfig = {};

/** @type {import('rollup').RollupOptions} */
const config = {
  input: 'src/app.ts',
  output: {
    dir: 'dist',
    format: 'es',
    name: 'Heron',
    entryFileNames: '[name].[hash].js',
    chunkFileNames: '[name].[hash].js',
  },
  plugins: [
    html({ template: (opts) => indexHtml(opts, ['app.']) }),
    minifyHTML(),
    copy(copyConfig),
    resolve({ extensions }),
    commonjs(),
    babel({
      extensions,
      babelHelpers: 'bundled',
      include: ['src/**/*'],
    }),
  ],
};
const isDevelopment = process.env.NODE_ENV !== 'production';

if (isDevelopment) {
  config.watch = {};
  config.output.sourcemap = true;
  config.plugins = [
    ...config.plugins,
    dev({ dirs: ['dist'], host: 'localhost', spa: './index.html',  }),
    livereload({
      watch: ['dist'],
    }),
  ];
}

if (!isDevelopment) {
  config.output.sourcemap = false;
  config.plugins = [
    ...config.plugins,
    terser({}),
  ];
}

export default config;
