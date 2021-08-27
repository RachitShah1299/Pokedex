export const fetcher = (...args) =>
  fetch(...args).then(async (res) => {
    if (res.status > 399) {
      throw new Error(
        JSON.stringify({ status: res.status, message: await res.json() })
      );
    }
    return res.json();
  });
