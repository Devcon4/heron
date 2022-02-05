import { css } from 'lit';

export const flexHostStyles = css`
  :host {
    display: flex;
    flex-direction: column;
    flex: 1;
    min-height: 0px;
  }
`;

export const ShadowStyles = css`
  .el-small {
    filter: drop-shadow(0px 1px 2px rgba(0, 0, 0, 0.2));
  }
  .el-medium {
    filter: drop-shadow(0px 2px 4px rgba(0, 0, 0, 0.2));
  }
  .el-large {
    filter: drop-shadow(0px 4px 6px rgba(0, 0, 0, 0.2));
  }
`;

export const MinWidthStyles = css`
  :host {
    flex-direction: row;
    justify-content: center;
  }
  .flex {
    max-width: 1240px;
  }
`;

export const globalStyles = css`
  a {
    color: var(--hero-on-surface);
    font-weight: 500;
    font-size: 18px;
    text-decoration: none;
    transition: all 150ms linear;
  }

  a:hover {
    transform: translateY(-1px);
    filter: brightness(10%);
    filter: drop-shadow(0 2px 4px rgba(0, 0, 0, 0.1));
    color: var(--hero-primary);
  }

  .flex {
    display: flex;
    flex-direction: column;
    flex: 1;
    min-height: 0px;
  }

  .fill {
    flex: 1;
  }

  h1,
  h2 {
    font-weight: 300;
    font-size: 42px;
    margin: 0px;
    padding-bottom: 42px;
  }

  mwc-button {
    --mdc-theme-on-primary: var(--hero-on-primary);
  }
`;

export const fadeinAnimation = css`
  @keyframes fadein {
    from {
      opacity: 0;
    }

    to {
      opacity: 1;
    }
  }
`;
