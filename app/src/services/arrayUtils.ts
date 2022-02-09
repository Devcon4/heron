export type Lookup<T = string> = { [key: string]: T };
export type HashTable = { lookup: Lookup; inverse: Lookup };

export const order =
  <T, U>(property: (obj: T) => U, order: 'Asc' | 'Desc' = 'Desc') =>
  (a: T, b: T) => {
    if (order === 'Asc') return property(a) < property(b) ? -1 : 1;
    return property(a) > property(b) ? -1 : 1;
  };

export const groupBy = <T>(
  list: T[],
  property: (obj: T) => string
): Lookup<T[]> => {
  const lookup: Lookup<T[]> = {};

  for (let item of list) {
    lookup[property(item)] = [...(lookup[property(item)] || []), item];
  }

  return lookup;
};
