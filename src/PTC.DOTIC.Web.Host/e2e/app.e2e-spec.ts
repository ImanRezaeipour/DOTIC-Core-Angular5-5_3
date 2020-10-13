import { DOTICPage } from './app.po';

describe('abp-zero-template App', function () {
    let page: DOTICPage;

    beforeEach(() => {
        page = new DOTICPage();
    });

    it('should display message saying app works', () => {
        page.navigateTo();
        page.getCopyright().then(value => {
            expect(value).toEqual(new Date().getFullYear() + ' © DOTIC.');
        });
    });
});
